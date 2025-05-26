using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;

namespace ApplyFlow
{
    public partial class FormHome : Form
    {

        private ApplicationService applicationService = new ApplicationService();
        //private User user = User.GetInstance();
        public FormHome()
        {
            InitializeComponent();
            LoadApplciations();
           
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


    }
}
