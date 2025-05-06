using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;

namespace ApplyFlow
{
    public partial class Home : Form
    {

        private ApplicationService applicationService = new ApplicationService();
        //private User user = User.GetInstance();
        public Home()
        {
            InitializeComponent();
            LoadApplciations();
           
        }
        public void LoadApplciations()
        {
            List<Application> userApplications = applicationService.GetApplications();
            //DataGridViewButtonColumn editButton = new DataGridViewButtonColumn();
            //editButton.Name = "EditButton";
            //editButton.HeaderText = "";
            //editButton.Text = "Edit";
            //editButton.UseColumnTextForButtonValue = true; // Shows the same text in all rows
            //dataGridAppList.Columns.Add(editButton);

            dataGridAppList.Columns.Add("jobTitle", "Job Title");
            dataGridAppList.Columns.Add("company", "Company");
            dataGridAppList.Columns.Add("status", "Status");
            dataGridAppList.Columns.Add("score", "Interest");
            dataGridAppList.Columns.Add("salary", "Salary");
            dataGridAppList.Columns.Add("openDate", "Open Date");
            dataGridAppList.Columns.Add("expiryDate", "Expiry Date");
            dataGridAppList.Columns.Add("startDate", "Start Date");
            dataGridAppList.Columns.Add("workMode", "Work Mode");
            dataGridAppList.Columns.Add("document", "Document");
            dataGridAppList.Columns.Add("industry", "Industry");
            dataGridAppList.Columns.Add("platform", "Platform");
            dataGridAppList.Columns.Add("url", "URL");

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
                DateTime? open = job.GetOpenDate();
                DateTime? expiry = job.GetExpiryDate();
                DateTime? start = job.GetStartDate();
                string workmode = job.GetWorkMode();

                // get file names of documents
                string filenames = ApplicationService.GetFilenames(a.GetDocuments());

                // get employer industries
                string industries = ApplicationService.GetIndustryNames(employer.GetIndustries());

                string platform = job.GetPlatform();
                string url = job.GetURL();

                dataGridAppList.Rows.Add(title, company, status, score, salary, open, expiry, start, workmode, filenames, industries, platform, url);
            }
        }

        private void buttonNewApplication_Click(object sender, EventArgs e)
        {
            FormNewApplication newApplication = new FormNewApplication();
            this.Hide();
            newApplication.ShowDialog();
        }
    }
}
