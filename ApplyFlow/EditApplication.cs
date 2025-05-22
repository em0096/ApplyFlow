using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplyFlow
{
    public partial class FormEditApplication : Form
    {

        private ApplicationService applicationService;
        private Application _selectedApplication;
        public FormEditApplication(Application application)
        {
            InitializeComponent();
            _selectedApplication = application;
            PopulateForm();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your Application has been deleted.");
            this.Hide();
            FormHome home = new FormHome();
            home.Show();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormHome home = new FormHome();
            home.Show();
        }

        private void buttonCreateNew_Click(object sender, EventArgs e)
        {
            // update application in Database

        }

        public void PopulateForm()
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
            comboBoxWorkMode.SelectedItem = job.GetWorkMode();
            textBoxURL.Text = job.GetURL();
            textBoxPlatform.Text = job.GetPlatform();

            textBoxCompany.Text = job.GetCompany();
            textBoxCity.Text = employer.GetCity();
            textBoxCountry.Text = employer.GetCountry();
            textBoxWebsite.Text = employer.GetWebsite();

            textBoxAppliedDate.Text = record.GetAppliedDate()?.ToString("yyyy-MM-dd") ?? "";
            comboBoxStatus.SelectedItem = record.GetStatus();

            // display industries
            foreach (string s in employer.GetIndustries())
            {
                listBoxIndustryList.Items.Add(s);
            }
            // display documents
            foreach (Document d in _selectedApplication.GetDocuments())
            {
                listBoxDocuments.Items.Add(d.GetFilename());
            }
        }

        private void buttonAddIndustry_Click(object sender, EventArgs e)
        {
            // get industry from textbox
            string industry = textBoxIndustry.Text;

            // add to listbox
            if (listBoxIndustryList.Items.Contains(industry))
            {
                MessageBox.Show("That item is already in the list.", "Duplicate Item");
                return;
            }
            listBoxIndustryList.Items.Add(industry);
        }

        private void buttonRemoveIndustry_Click(object sender, EventArgs e)
        {
            listBoxIndustryList.Items.Remove(listBoxIndustryList.SelectedItem);
        }

        private void buttonSelectDoc_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;
                string selectedFilename = Path.GetFileNameWithoutExtension(selectedFilePath);
                if (listBoxDocuments.Items.Contains(selectedFilename + ", " + selectedFilePath))
                {
                    MessageBox.Show("That item is already in the list.", "Duplicate Item");
                    return;
                }
                listBoxDocuments.Items.Add(selectedFilename + ", " + selectedFilePath);
            }
        }

        //private void button1_Click(object sender, EventArgs e)
        //{

        //}

        private void buttonRemoveDoc_Click(object sender, EventArgs e)
        {
            listBoxDocuments.Items.Remove(listBoxDocuments.SelectedItem);
        }
    }
}
