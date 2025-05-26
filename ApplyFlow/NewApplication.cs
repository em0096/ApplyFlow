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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ApplyFlow
{
    public partial class FormNewApplication : Form
    {
        private ApplicationService _applicationService = new ApplicationService();
        private EmployerService _employerService = new EmployerService();
        private DocumentService _documentService= new DocumentService();
        private JobService _jobService = new JobService();  

        private List<Document> _userDocuments = new List<Document>();

        private List<Document> _selectedDocList = new List<Document>();
        private List<string> _selectedIndustryList = new List<string>();

        private bool _isComboLoading = true;
        public FormNewApplication()
        {
            InitializeComponent();
            PopulateIndustryComboBox();
            PopulateDocumentComboBox();
            PopulatePlatformComboBox();
        }

        private void buttonCreateNew_Click(object sender, EventArgs e)
        {

            string jobTitle = textBoxJobTitle.Text.Trim();
            string company = textBoxCompany.Text.Trim();

            if (jobTitle == "" || company == "" || !pickerExpiry.Checked)
            {
                MessageBox.Show("All fields marked with * are required. Please complete them before submitting.", "Form Incomplete");
                return;
            }

            DateTime expiryDate = pickerExpiry.Value;
            DateTime? openDate = pickerOpen.Checked ? pickerOpen.Value : (DateTime?)null;
            DateTime? startDate = pickerStart.Checked ? pickerStart.Value : (DateTime?)null;
            DateTime appliedDate = pickerApplied.Checked ? pickerApplied.Value : DateTime.Today;

            if(!ValidateDateInput(openDate, appliedDate, expiryDate, startDate))
            {
                return;
            }

            int? score = null;

            if (comboBoxScore.SelectedItem != null)
            {
                score = Convert.ToInt32(comboBoxScore.SelectedItem.ToString());
            }

            string salary = comboBoxSalary.SelectedItem?.ToString().Trim();
            string workMode = comboBoxWorkMode.SelectedItem?.ToString().Trim();
            string city = textBoxCity.Text.Trim();
            string country = textBoxCountry.Text.Trim();
            string website = textBoxWebsite.Text.Trim();
            string url = textBoxURL.Text.Trim();
            string platform = textBoxPlatform.Text.Trim();
            string status = comboBoxStatus.SelectedItem?.ToString().Trim();

            Employer employer = new Employer(company, website, city, country);
            Job job = new Job(0, jobTitle, company, score, salary, openDate, expiryDate, startDate, workMode, url, platform);
            Record record = new Record(status, appliedDate, 0);

            if (_applicationService.InsertApplication(employer, _selectedIndustryList, job, _selectedDocList, record)) 
            {
                MessageBox.Show("Application Saved.");
                ReturnHome();
                return;
            }
            MessageBox.Show("You have already applied for this job.");
        }

        // Check date inputs are reasonable 
        public bool ValidateDateInput(DateTime? openDate, DateTime? appliedDate, DateTime? expiryDate, DateTime? startDate)
        {
            // Applied date is required
            if (appliedDate > DateTime.Now)
            {
                MessageBox.Show("Applied date cannot be in the future.");
                return false;
            }

            if (expiryDate.HasValue && expiryDate < DateTime.Today)
            {
                MessageBox.Show("Expiry date cannot be in the past.");
                return false;
            }

            if (startDate.HasValue && startDate < DateTime.Today)
            {
                MessageBox.Show("Start date must be in the future.");
                return false;
            }

            if (openDate.HasValue && appliedDate < openDate)
            {
                MessageBox.Show("Applied date cannot be before the open date.");
                return false;
            }

            if (expiryDate.HasValue && appliedDate > expiryDate)
            {
                MessageBox.Show("Applied date cannot be after the expiry date.");
                return false;
            }

            if (expiryDate.HasValue && startDate.HasValue && expiryDate > startDate)
            {
                MessageBox.Show("Start date must be after expiry date.");
                return false;
            }

            return true;
        }
        private void buttonSelectDoc_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                string filePath = openFileDialog.FileName;
                string fileName = Path.GetFileNameWithoutExtension(filePath);
                Document selectedDoc = new Document(fileName, filePath);
                if (IsDuplicate(selectedDoc))
                {
                    return;
                }
                _selectedDocList.Add(selectedDoc);
                UpdateDocumentListBox();
            }
        }

        private void comboBoxDoc_Select(object sender, EventArgs e)
        {
            Document selectedDoc = comboBoxDoc.SelectedItem as Document;

            if (_isComboLoading || string.IsNullOrWhiteSpace(selectedDoc.GetFileName())) return; // check if window loading or doc is empty

            if (IsDuplicate(selectedDoc))
            {
                return;
            }
            _selectedDocList.Add(selectedDoc);
            UpdateDocumentListBox();
        }

        private void UpdateDocumentListBox()
        {
            listBoxDocuments.DataSource = null;
            listBoxDocuments.DataSource = _selectedDocList;
        }
        private void UpdateIndustryListBox()
        {
            listBoxIndustryList.DataSource = null;
            listBoxIndustryList.DataSource = _selectedIndustryList;
        }
        private bool IsDuplicate(Document doc)
        {
            if (_selectedDocList.Contains(doc))
            {
                MessageBox.Show("That file is already in the list.", "Duplicate File");
                return true;
            }
            return false;
        }

        private void buttonAddIndustry_Click(object sender, EventArgs e)
        {
            string selectedText = comboBoxIndustry.Text.Trim();

            if (string.IsNullOrWhiteSpace(selectedText))
                return;

            if (_selectedIndustryList.Contains(selectedText))
            {
                MessageBox.Show("That industry is already in the list.", "Duplicate Industry");
                return;
            }

            _selectedIndustryList.Add(selectedText);
            UpdateIndustryListBox();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            ReturnHome();
        }

        private void buttonRemoveIndustry_Click(object sender, EventArgs e)
        {
            _selectedIndustryList.Remove(comboBoxIndustry.Text.Trim());
            UpdateIndustryListBox();
        }

        private void buttonRemoveDoc_Click(object sender, EventArgs e)
        {
            _selectedDocList.Remove(comboBoxDoc.SelectedItem as Document);
            UpdateDocumentListBox();
        }
        public void ReturnHome()
        {
            this.Hide();
            FormHome home = new FormHome();
            home.Show();
        }
        public void PopulateIndustryComboBox()
        {
            foreach (string i in _employerService.GetIndustryList())
            {
                comboBoxIndustry.Items.Add(i);
            }
        }

        public void PopulateDocumentComboBox()
        {
            _isComboLoading = true;
            Document dummy = new Document("","");
            _userDocuments.Add(dummy);
            _userDocuments.AddRange(_documentService.GetUserDocuments());
            comboBoxDoc.DataSource = _userDocuments;
            _isComboLoading = false;
        }

        public void PopulatePlatformComboBox()
        {
            foreach (string p in _jobService.GetPlatformList())
            {
                if (p != "")
                {
                    comboBoxPlatform.Items.Add(p);
                }
            }
        }


    }
}

