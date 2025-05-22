using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplyFlow
{
    public partial class FormNewApplication : Form
    {
        private ApplicationService applicationService = new ApplicationService();
        public FormNewApplication()
        {
            InitializeComponent();
            
        }

        private void buttonCreateNew_Click(object sender, EventArgs e)
        {
            string jobTitle = textBoxJobTitle.Text;
            string company = textBoxCompany.Text;
            string startInput= textBoxStartDate.Text;
            int? score = 0;
            if (!string.IsNullOrWhiteSpace(textBoxScore.Text))
            {
                score = Convert.ToInt32(textBoxScore.Text);
            }
            string salary = textBoxSalary.Text;
            string workMode = comboBoxWorkMode.SelectedItem?.ToString();
            string city = textBoxCity.Text;
            string country = textBoxCountry.Text;
            string website = textBoxWebsite.Text;
            string url = textBoxURL.Text;
            string expiryInput = textBoxExpiryDate.Text;
            string platform = textBoxPlatform.Text;
            string status = comboBoxStatus.SelectedItem?.ToString();
            string openInput = textBoxOpenDate.Text;
            string appliedInput = textBoxAppliedDate.Text;

            if (checkIfEmpty(jobTitle) || checkIfEmpty(company) || checkIfEmpty(expiryInput) || checkIfEmpty(city) || checkIfEmpty(country))
            {
                return;
            }

            DateTime? startDate = ParseDateFromInput(startInput, "Start Date");
            DateTime? expiryDate = ParseDateFromInput(expiryInput, "Expiry Date"); 
            DateTime? openDate = ParseDateFromInput(openInput, "Open Date");
            DateTime? appliedDate = ParseDateFromInput(appliedInput, "Applied Date");

            // check dates are resonable e.g. expiry after open 

            // get items from document list box 
            List<Document> docList = new List<Document>();
            foreach (string s in listBoxDocuments.Items)
            {
                string[] temp = s.Split(',');
                string filename = temp[0];
                string filepath = temp[1];
                Document doc = new Document(filename, filepath);
                docList.Add(doc);   
            }

            // get items from industry list box 
            List<string> industryList = new List<string>();
            foreach(string s in listBoxIndustryList.Items)
            {
                industryList.Add(s);
            }

            Employer employer = new Employer(company, website, city, country);
            Job job = new Job(0, jobTitle, company, score, salary, openDate, expiryDate, startDate, workMode, url, platform);
            Record record = new Record(status, appliedDate, 0);
            applicationService.InsertApplication(employer, industryList, job, docList, record);

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

        public DateTime? ParseDateFromInput(string dateInput, string dateLabel)
        {
            string format = "dd/MM/yyyy";
            if (string.IsNullOrWhiteSpace(dateInput))
            {
                return null; // no user input
            }
            if (DateTime.TryParseExact(dateInput, format, CultureInfo.InvariantCulture,DateTimeStyles.None, out DateTime parsedDate))
            {
                return parsedDate;
            }
            MessageBox.Show(dateLabel + " is in the wrong format. Please use " + format + ".", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return null;
        }
        private bool checkIfEmpty(string input)
        {
            bool isEmpty = false;
            if (input == "")
            {
                MessageBox.Show("All fields marked with * are required. Please complete them before submitting.", "Form Incomplete");
                isEmpty = true;
            }
            return isEmpty;
        }

        private void buttonAddIndustry_Click(object sender, EventArgs e)
        {
            // get industry from textbox
            string industry = textBoxIndustry.Text;

            // add to listbox
            if (listBoxIndustryList.Items.Contains(industry)) {
                MessageBox.Show("That item is already in the list.", "Duplicate Item");
                return;
            }
            listBoxIndustryList.Items.Add(industry);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormHome home = new FormHome();
            home.Show();
        }

        private void buttonRemoveIndustry_Click(object sender, EventArgs e)
        {
            listBoxIndustryList.Items.Remove(listBoxIndustryList.SelectedItem);
        }

        private void buttonRemoveDoc_Click(object sender, EventArgs e)
        {
            listBoxDocuments.Items.Remove(listBoxDocuments.SelectedItem);
        }
    }
}

