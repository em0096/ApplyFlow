using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ApplyFlow
{
    public partial class FormViewApplication : Form
    {
        private Application _selectedApplication;
        public FormViewApplication(Application selectedApplication)
        {
            InitializeComponent();
            _selectedApplication = selectedApplication;
            loadApplication();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormHome home = new FormHome();
            home.ShowDialog();
        }

        private void buttonCreateNew_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormEditApplication form = new FormEditApplication(_selectedApplication);
            form.Show();
        }

        private async void loadApplication()
        {
            Record record = _selectedApplication.GetRecord();
            Job job = _selectedApplication.GetJob();
            Employer employer = _selectedApplication.GetEmployer();

            textBoxJobTitle.Text = job.GetTitle();
            textBoxScore.Text = job.GetScore().ToString();
            textBoxSalary.Text = job.GetSalary();
            textBoxOpenDate.Text = job.GetOpenDate()?.ToString("yyyy-MM-dd") ?? "";
            textBoxExpiryDate.Text = job.GetExpiryDate()?.ToString("yyyy-MM-dd") ?? ""; 
            textBoxStartDate.Text = job.GetStartDate()?.ToString("yyyy-MM-dd") ?? "";
            textBoxWorkMode.Text = job.GetWorkMode();
            textBoxURL.Text = job.GetURL();
            textBoxPlatform.Text = job.GetPlatform();

            textBoxCompany.Text = job.GetCompany();
            textBoxCity.Text = employer.GetCity();
            textBoxCountry.Text = employer.GetCountry();
            textBoxWebsite.Text = employer.GetWebsite();

            textBoxAppliedDate.Text = record.GetAppliedDate()?.ToString("yyyy-MM-dd") ?? "";
            textBoxStatus.Text = record.GetStatus();

            // display industries
            foreach(string s in employer.GetIndustries())
            {
                listBoxIndustryList.Items.Add(s);
            }
            // display documents
            foreach(Document d in _selectedApplication.GetDocuments())
            {
                listBoxDocuments.Items.Add(d.GetFilename());
            }
        }


    }
}
