using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace ApplyFlow
{
    public partial class FormHome : Form
    {
        DatabaseManager dbManager = new DatabaseManager();
        private ApplicationService applicationService = new ApplicationService();
        //private User user = User.GetInstance();
        public FormHome()
        {

            InitializeComponent();
            LoadApplciations();
            LoadCountry();
            LoadUpcomingInterviews();
            avgSalary();
            LoadApplicationStatusBreakdown();
            UpdateUser();
            LoadAvailableJobsByCity();
            LoadUserApplicationCount();
            LoadCurrentlyAvailableJobCount();
        }

        public void UpdateUser()
        {
            string currentUser = ApplyFlow.User.GetInstance().GetUsername();
            User.Text = "Current User: " + currentUser;
        }
       

        public void avgSalary()
        {
            try
            {
                string query = @"
                SELECT ROUND(AVG((low + high) / 2)) AS average_salary
                FROM (
                    SELECT
                        TO_NUMBER(REGEXP_SUBSTR(salary, '\d+')) AS low,
                        TO_NUMBER(NVL(REGEXP_SUBSTR(salary, '\d+', 1, 2), REGEXP_SUBSTR(salary, '\d+'))) AS high
                    FROM Job
                    WHERE REGEXP_LIKE(salary, '^\$?\d+(-\d+)?k(\s*NZD)?$', 'i')
                )";

                Dictionary<string, object> parameters = new Dictionary<string, object>();
                DataTable result = dbManager.SelectQuery(query, parameters);

                if (result != null && result.Rows.Count > 0)
                {
                    string avgSalary = result.Rows[0]["average_salary"].ToString();
                    Avg.Text = "Average Salary: $" + avgSalary.ToString() + "K";
                }
                else
                {
                    Avg.Text = "No valid salary data found.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching average salary: " + ex.Message);
            }
        }

        public void LoadUserApplicationCount()
        {
            try
            {
                string query = "SELECT COUNT(*) AS total_user_applications FROM Application WHERE username = :username";

                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add(":username", ApplyFlow.User.GetInstance().GetUsername());

                DataTable result = dbManager.SelectQuery(query, parameters);

                if (result != null && result.Rows.Count > 0)
                {
                    string total = result.Rows[0]["total_user_applications"].ToString();
                    CountJobsUser.Text = total.ToString() + ": Total applications submitted";
                }
                else
                {
                    CountJobsUser.Text = "No applications found for this user.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading application count: " + ex.Message);
            }
        }

        public void LoadCurrentlyAvailableJobCount()
        {
            try
            {
                string query = "SELECT COUNT(*) AS currently_available_jobs FROM Job WHERE expiry_date > SYSDATE";

                DataTable result = dbManager.SelectQuery(query, new Dictionary<string, object>());

                if (result != null && result.Rows.Count > 0)
                {
                    string total = result.Rows[0]["currently_available_jobs"].ToString();
                    CurrentJobs.Text = total.ToString() + ": Jobs currently available";
                }
                else
                {
                    CurrentJobs.Text = "No jobs are currently open";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading current job count: " + ex.Message);
            }
        }

        public void LoadAvailableJobsByCity()
        {
            try
            {
                string query = "SELECT e.city, COUNT(*) AS available_jobs FROM Job j JOIN Employer e ON j.company_name = e.company_name WHERE j.expiry_date > SYSDATE GROUP BY e.city";

                Dictionary<string, object> parameters = new Dictionary<string, object>();
                DataTable result = dbManager.SelectQuery(query, parameters);

                if (result != null && result.Rows.Count > 0)
                {
                    listBoxCityNow.Items.Clear();
                    foreach (DataRow row in result.Rows)
                    {
                        string city = row["city"].ToString();
                        string numberOfJobs = row["available_jobs"].ToString();
                        listBoxCityNow.Items.Add("City: " + city + ", # Of Open Jobs: " + numberOfJobs);
                    }
                }
                else
                {
                    listBoxCityNow.Items.Clear();
                    listBoxCityNow.Items.Add("No currently available jobs found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading available jobs by country: " + ex.Message);
            }
        }

        public void LoadUpcomingInterviews()
        {
            string currentUser = ApplyFlow.User.GetInstance().GetUsername();
            try
            {
                string query = "SELECT i.scheduled_at, i.type, a.username, q.title, q.company_name FROM Interview i JOIN Applicant a ON a.username = i.username JOIN Job q ON q.id = i.job_id WHERE a.username = :username AND i.scheduled_at > :currentTime ORDER BY i.scheduled_at";

                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add(":username", currentUser);
                parameters.Add(":currentTime", DateTime.Now);

                DataTable result = dbManager.SelectQuery(query, parameters);
                MessageBox.Show("Sending timestamp: " + ((DateTime)parameters[":currentTime"]).ToString("yyyy-MM-dd HH:mm:ss"));

                if (result != null && result.Rows.Count > 0)
                {
                    listBoxInterviews.Items.Clear();
                    foreach (DataRow row in result.Rows)
                    {
                        string date = Convert.ToDateTime(row["scheduled_at"]).ToString("yyyy-MM-dd HH:mm");
                        string type = row["type"].ToString();
                        string title = row["title"].ToString();
                        string company = row["company_name"].ToString();
                        listBoxInterviews.Items.Add("Company Name: " + company + ", Date And Time: " + date + ", Interview Type: " + type + ", Job Title: " + title);
                    }
                }
                else
                {
                    listBoxInterviews.Items.Clear(); // or show "No upcoming interviews"
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading interviews: " + ex.Message);
            }
        }

        public void LoadApplicationStatusBreakdown()
        {
            try
            {
                string query = @"
                    SELECT LOWER(status) AS status, COUNT(*) AS count
                    FROM Application
                    WHERE username = :username
                    GROUP BY LOWER(status)";

                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add(":username", ApplyFlow.User.GetInstance().GetUsername());

                DataTable result = dbManager.SelectQuery(query, parameters);

                int successful = 0;
                int declined = 0;
                int pending = 0;

                if (result != null && result.Rows.Count > 0)
                {
                    foreach (DataRow row in result.Rows)
                    {
                        string status = row["status"].ToString().ToLower();
                        int count = Convert.ToInt32(row["count"]);

                        if (status == "offer received")
                        {
                            successful += count;
                        }
                        else if (status == "declined")
                        {
                            declined += count;
                        }
                        else
                        {
                            pending += count;
                        }
                    }

                    SPD.Text = $" Application Status Overview: \n Successful: {successful}\n Declined: {declined}\n Pending: {pending}";
                }
                else
                {
                    SPD.Text = "No application data found for the current user.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading application status breakdown: " + ex.Message);
            }
        }

        public void LoadCountry()
        {
            try
            {
                string query = "SELECT city, COUNT(*) AS number_of_companies FROM Employer GROUP BY city";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                DataTable result = dbManager.SelectQuery(query, parameters);

                if (result != null && result.Rows.Count > 0)
                {
                    listBoxCountry.Items.Clear();
                    foreach (DataRow row in result.Rows)
                    {
                        string City = row["City"].ToString();
                        string Number_of_compaines = row["Number_Of_Companies"].ToString();
                        listBoxCountry.Items.Add("City: " + City + ", # Of Companies: " + Number_of_compaines);
                    }
                }
                else
                {
                    listBoxCountry.Items.Clear(); // or show "No upcoming interviews"
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in loading County stats: " + ex.Message);
            }
        }
        public void LoadApplciations()
        {
            List<Application> userApplications = applicationService.GetApplications();

            DataGridViewButtonColumn action = new DataGridViewButtonColumn();
            action.Name = "action";
            action.HeaderText = "Action";
            action.Text = "View";
            action.UseColumnTextForButtonValue = true; 
            dataGridApplications.Columns.Add(action);
            dataGridApplications.CellContentClick += viewButton_Click;   // add click event to cell

            dataGridApplications.Columns.Add("jobTitle", "Job Title");
            dataGridApplications.Columns.Add("company", "Company");
            dataGridApplications.Columns.Add("status", "Status");
            dataGridApplications.Columns.Add("score", "Interest");
            dataGridApplications.Columns.Add("salary", "Salary");
            dataGridApplications.Columns.Add("openDate", "Open Date");
            dataGridApplications.Columns.Add("expiryDate", "Expiry Date");
            dataGridApplications.Columns.Add("startDate", "Start Date");
            dataGridApplications.Columns.Add("workMode", "Work Mode");
            //dataGridApplications.Columns.Add("document", "Document");
            ////dataGridApplications.Columns.Add("industry", "Industry");
            //dataGridApplications.Columns.Add("platform", "Platform");
            //dataGridApplications.Columns.Add("url", "URL");

            foreach (Application a in userApplications)
            {
                Record record = a.GetRecord();
                Job job = a.GetJob();
                Employer employer = a.GetEmployer();

                string title = job.GetTitle();
                string company = job.GetCompany();
                string status = record.GetStatus();
                int? score = job.GetScore();
                string salary = job.GetSalary();
                string open = job.GetOpenDate()?.ToString("yyyy-MM-dd") ?? "";
                string expiry = job.GetExpiryDate()?.ToString("yyyy-MM-dd") ?? "";
                string start = job.GetStartDate()?.ToString("yyyy-MM-dd") ?? "";
                string workmode = job.GetWorkMode();

                //// get file names of documents
                //string filenames = ApplicationService.GetFilenames(a.GetDocuments());

                //// get employer industries
                //string industries = ApplicationService.GetIndustryNames(employer.GetIndustries());

                string platform = job.GetPlatform();
                string url = job.GetURL();

                //int index = dataGridApplications.Rows.Add(title, company, status, score, salary, open, expiry, start, workmode, filenames, industries, platform, url);
                int index = dataGridApplications.Rows.Add(null, title, company, status, score, salary, open, expiry, start, workmode);
                DataGridViewRow row = dataGridApplications.Rows[index];
                row.Tag = a; // attach application to row
            }
        }

        private void buttonNewApplication_Click(object sender, EventArgs e)
        {
            FormNewApplication newApplication = new FormNewApplication();
            this.Hide();
            newApplication.ShowDialog();
        }

        private void viewButton_Click(object sender, DataGridViewCellEventArgs e)
        {
            // check user clicked the action column e.g. the edit button column and that they didnt click the header row
            if (e.ColumnIndex == dataGridApplications.Columns["action"].Index & e.RowIndex >= 0)
            {
                this.Hide();
                DataGridViewRow selectedRow = dataGridApplications.Rows[e.RowIndex];
                Application selectedApplication = selectedRow.Tag as Application; // extract applciation from row tag
                FormViewApplication viewApplication = new FormViewApplication(selectedApplication);
                viewApplication.ShowDialog();   
            }
        }

        private void dataGridApplications_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listBoxCountry_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
