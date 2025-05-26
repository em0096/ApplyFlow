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
        private List<Document> _userDocuments = new List<Document>();
        private List<Document> _selectedDocList = new List<Document>();
        private bool _isComboLoading = true;
        public FormNewApplication()
        {
            InitializeComponent();
            PopulateIndustryComboBox();
            PopulateDocumentComboBox();

        }

        private void buttonCreateNew_Click(object sender, EventArgs e)
        {
            //string startInput = textBoxStartDate.Text.Trim();
            //string openInput = textBoxOpenDate.Text.Trim();
            //string appliedInput = textBoxAppliedDate.Text.Trim();
            //string expiryInput = textBoxExpiryDate.Text.Trim();

            DateTime? openDate = pickerOpen.Checked ? pickerOpen.Value : (DateTime?)null;
            DateTime expiryDate = pickerExpiry.Checked ? pickerExpiry.Value : DateTime.MinValue;
            DateTime? startDate = pickerStart.Checked ? pickerStart.Value : (DateTime?)null;
            DateTime appliedDate = pickerApplied.Checked ? pickerApplied.Value : DateTime.Now;

            if(!ValidateDateInput(openDate, expiryDate, startDate, appliedDate))
            {
                return;
            }

            string jobTitle = textBoxJobTitle.Text.Trim();
            string company = textBoxCompany.Text.Trim();

            int? score = null;
            string salary = comboBoxSalary.SelectedItem?.ToString().Trim();

            if (comboBoxScore.SelectedItem != null)
            {
                score = Convert.ToInt32(comboBoxScore.SelectedItem.ToString());
            }

            string workMode = comboBoxWorkMode.SelectedItem?.ToString().Trim();
            string city = textBoxCity.Text.Trim();
            string country = textBoxCountry.Text.Trim();
            string website = textBoxWebsite.Text.Trim();
            string url = textBoxURL.Text.Trim();
            string platform = textBoxPlatform.Text.Trim();
            string status = comboBoxStatus.SelectedItem?.ToString().Trim();

            if (CheckIfEmpty(jobTitle) || CheckIfEmpty(company))
            {
                return;
            }

            //DateTime? startDate = ParseDateFromInput(startInput, "Start Date");
            //DateTime? openDate = ParseDateFromInput(openInput, "Open Date");
            //DateTime? expiryDate = ParseDateFromInput(expiryInput, "Expiry Date");
            //DateTime? appliedDate = ParseDateFromInput(appliedInput, "Applied Date");

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

            if (_applicationService.InsertApplication(employer, industryList, job, docList, record)) 
            {
                MessageBox.Show("Application Saved.");
                ReturnHome();
                return;
            }
            MessageBox.Show("You have already applied for this job.");
        }
        public bool ValidateDateInput(DateTime? openDate, DateTime? appliedDate, DateTime? expiryDate, DateTime? startDate)
        {
            // Applied date is required
            if (appliedDate > DateTime.Today)
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
            if (_isComboLoading) return;

            Document selectedDoc = comboBoxDoc.SelectedItem as Document;

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

        private bool IsDuplicate(Document doc)
        {
            if (_selectedDocList.Contains(doc))
            {
                MessageBox.Show("That file is already in the list.", "Duplicate File");
                return true;
            }
            return false;
        }
        private bool CheckIfEmpty(string input)
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
            ReturnHome();
        }

        private void buttonRemoveIndustry_Click(object sender, EventArgs e)
        {
            listBoxIndustryList.Items.Remove(listBoxIndustryList.SelectedItem);
        }

        private void buttonRemoveDoc_Click(object sender, EventArgs e)
        {
            listBoxDocuments.Items.Remove(listBoxDocuments.SelectedItem);
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

        //public DateTime? ParseDateFromInput(string dateInput, string dateLabel)
        //{
        //    string format = "dd/MM/yyyy";
        //    if (string.IsNullOrWhiteSpace(dateInput))
        //    {
        //        return null; // no user input
        //    }
        //    if (DateTime.TryParseExact(dateInput, format, CultureInfo.InvariantCulture,DateTimeStyles.None, out DateTime parsedDate))
        //    {
        //        return parsedDate;
        //    }
        //    MessageBox.Show(dateLabel + " is in the wrong format. Please use " + format + ".", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    return null;
        //}
    }
}

