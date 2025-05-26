namespace ApplyFlow
{
    partial class FormNewApplication
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialogSelectDoc = new System.Windows.Forms.OpenFileDialog();
            this.labelNewApp = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pickerExpiry = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.labelExpiryDate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxURL = new System.Windows.Forms.TextBox();
            this.labelURL = new System.Windows.Forms.Label();
            this.textBoxPlatform = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBoxIndustry = new System.Windows.Forms.ComboBox();
            this.buttonRemoveIndustry = new System.Windows.Forms.Button();
            this.buttonAddIndustry = new System.Windows.Forms.Button();
            this.textBoxIndustry = new System.Windows.Forms.TextBox();
            this.listBoxIndustryList = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.labelEmployerIndustry = new System.Windows.Forms.Label();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.labelWebsite = new System.Windows.Forms.Label();
            this.textBoxWebsite = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelCompany = new System.Windows.Forms.Label();
            this.textBoxCompany = new System.Windows.Forms.TextBox();
            this.textBoxCountry = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBoxDoc = new System.Windows.Forms.ComboBox();
            this.comboBoxScore = new System.Windows.Forms.ComboBox();
            this.pickerApplied = new System.Windows.Forms.DateTimePicker();
            this.buttonRemoveDoc = new System.Windows.Forms.Button();
            this.labelScore = new System.Windows.Forms.Label();
            this.listBoxDocuments = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.buttonSelectDoc = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelIndustry = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelPlatform = new System.Windows.Forms.Label();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.pickerOpen = new System.Windows.Forms.DateTimePicker();
            this.labelOpenDate = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxSalary = new System.Windows.Forms.ComboBox();
            this.pickerStart = new System.Windows.Forms.DateTimePicker();
            this.comboBoxWorkMode = new System.Windows.Forms.ComboBox();
            this.labelWorkMode = new System.Windows.Forms.Label();
            this.labelStartDate = new System.Windows.Forms.Label();
            this.labelSalary = new System.Windows.Forms.Label();
            this.labelJobTitle = new System.Windows.Forms.Label();
            this.textBoxJobTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonCreateNew = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialogSelectDoc
            // 
            this.openFileDialogSelectDoc.FileName = "openFileDialogSelectDoc";
            this.openFileDialogSelectDoc.Title = "Select File(s)";
            // 
            // labelNewApp
            // 
            this.labelNewApp.AutoSize = true;
            this.labelNewApp.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewApp.Location = new System.Drawing.Point(14, 33);
            this.labelNewApp.Name = "labelNewApp";
            this.labelNewApp.Size = new System.Drawing.Size(212, 26);
            this.labelNewApp.TabIndex = 6;
            this.labelNewApp.Text = "New Job Application";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel4.Controls.Add(this.pickerExpiry);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.labelExpiryDate);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.textBoxURL);
            this.panel4.Controls.Add(this.labelURL);
            this.panel4.Controls.Add(this.textBoxPlatform);
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(19, 513);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(712, 86);
            this.panel4.TabIndex = 48;
            // 
            // pickerExpiry
            // 
            this.pickerExpiry.Checked = false;
            this.pickerExpiry.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pickerExpiry.Location = new System.Drawing.Point(378, 41);
            this.pickerExpiry.MinDate = new System.DateTime(2025, 5, 25, 0, 0, 0, 0);
            this.pickerExpiry.Name = "pickerExpiry";
            this.pickerExpiry.ShowCheckBox = true;
            this.pickerExpiry.Size = new System.Drawing.Size(150, 26);
            this.pickerExpiry.TabIndex = 42;
            this.pickerExpiry.Value = new System.DateTime(2025, 5, 25, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(543, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 19);
            this.label6.TabIndex = 24;
            this.label6.Text = "Platform";
            // 
            // labelExpiryDate
            // 
            this.labelExpiryDate.AutoSize = true;
            this.labelExpiryDate.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExpiryDate.Location = new System.Drawing.Point(374, 19);
            this.labelExpiryDate.Name = "labelExpiryDate";
            this.labelExpiryDate.Size = new System.Drawing.Size(89, 19);
            this.labelExpiryDate.TabIndex = 22;
            this.labelExpiryDate.Text = "Expiry Date *";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 26);
            this.label5.TabIndex = 7;
            // 
            // textBoxURL
            // 
            this.textBoxURL.ForeColor = System.Drawing.SystemColors.Menu;
            this.textBoxURL.Location = new System.Drawing.Point(28, 43);
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.Size = new System.Drawing.Size(330, 26);
            this.textBoxURL.TabIndex = 2;
            // 
            // labelURL
            // 
            this.labelURL.AutoSize = true;
            this.labelURL.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelURL.Location = new System.Drawing.Point(24, 19);
            this.labelURL.Name = "labelURL";
            this.labelURL.Size = new System.Drawing.Size(103, 19);
            this.labelURL.TabIndex = 23;
            this.labelURL.Text = "Job Listing URL";
            // 
            // textBoxPlatform
            // 
            this.textBoxPlatform.ForeColor = System.Drawing.SystemColors.Menu;
            this.textBoxPlatform.Location = new System.Drawing.Point(547, 41);
            this.textBoxPlatform.Name = "textBoxPlatform";
            this.textBoxPlatform.Size = new System.Drawing.Size(150, 26);
            this.textBoxPlatform.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel3.Controls.Add(this.comboBoxIndustry);
            this.panel3.Controls.Add(this.buttonRemoveIndustry);
            this.panel3.Controls.Add(this.buttonAddIndustry);
            this.panel3.Controls.Add(this.textBoxIndustry);
            this.panel3.Controls.Add(this.listBoxIndustryList);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.labelEmployerIndustry);
            this.panel3.Controls.Add(this.textBoxCity);
            this.panel3.Controls.Add(this.labelWebsite);
            this.panel3.Controls.Add(this.textBoxWebsite);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.labelCity);
            this.panel3.Controls.Add(this.labelCompany);
            this.panel3.Controls.Add(this.textBoxCompany);
            this.panel3.Controls.Add(this.textBoxCountry);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(19, 229);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(712, 268);
            this.panel3.TabIndex = 47;
            // 
            // comboBoxIndustry
            // 
            this.comboBoxIndustry.FormattingEnabled = true;
            this.comboBoxIndustry.Location = new System.Drawing.Point(445, 36);
            this.comboBoxIndustry.Name = "comboBoxIndustry";
            this.comboBoxIndustry.Size = new System.Drawing.Size(150, 28);
            this.comboBoxIndustry.TabIndex = 42;
            // 
            // buttonRemoveIndustry
            // 
            this.buttonRemoveIndustry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoveIndustry.Location = new System.Drawing.Point(445, 208);
            this.buttonRemoveIndustry.Name = "buttonRemoveIndustry";
            this.buttonRemoveIndustry.Size = new System.Drawing.Size(252, 39);
            this.buttonRemoveIndustry.TabIndex = 37;
            this.buttonRemoveIndustry.Text = "Remove";
            this.buttonRemoveIndustry.UseVisualStyleBackColor = true;
            this.buttonRemoveIndustry.Click += new System.EventHandler(this.buttonRemoveIndustry_Click);
            // 
            // buttonAddIndustry
            // 
            this.buttonAddIndustry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddIndustry.Location = new System.Drawing.Point(601, 35);
            this.buttonAddIndustry.Name = "buttonAddIndustry";
            this.buttonAddIndustry.Size = new System.Drawing.Size(97, 29);
            this.buttonAddIndustry.TabIndex = 35;
            this.buttonAddIndustry.Text = "Add";
            this.buttonAddIndustry.UseVisualStyleBackColor = true;
            this.buttonAddIndustry.Click += new System.EventHandler(this.buttonAddIndustry_Click);
            // 
            // textBoxIndustry
            // 
            this.textBoxIndustry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIndustry.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxIndustry.Location = new System.Drawing.Point(445, 36);
            this.textBoxIndustry.Name = "textBoxIndustry";
            this.textBoxIndustry.Size = new System.Drawing.Size(150, 26);
            this.textBoxIndustry.TabIndex = 36;
            // 
            // listBoxIndustryList
            // 
            this.listBoxIndustryList.FormattingEnabled = true;
            this.listBoxIndustryList.ItemHeight = 20;
            this.listBoxIndustryList.Location = new System.Drawing.Point(445, 80);
            this.listBoxIndustryList.Name = "listBoxIndustryList";
            this.listBoxIndustryList.Size = new System.Drawing.Size(252, 104);
            this.listBoxIndustryList.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 26);
            this.label9.TabIndex = 7;
            // 
            // labelEmployerIndustry
            // 
            this.labelEmployerIndustry.AutoSize = true;
            this.labelEmployerIndustry.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmployerIndustry.Location = new System.Drawing.Point(441, 10);
            this.labelEmployerIndustry.Name = "labelEmployerIndustry";
            this.labelEmployerIndustry.Size = new System.Drawing.Size(60, 19);
            this.labelEmployerIndustry.TabIndex = 25;
            this.labelEmployerIndustry.Text = "Industry";
            // 
            // textBoxCity
            // 
            this.textBoxCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCity.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxCity.Location = new System.Drawing.Point(28, 158);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(150, 26);
            this.textBoxCity.TabIndex = 3;
            // 
            // labelWebsite
            // 
            this.labelWebsite.AutoSize = true;
            this.labelWebsite.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWebsite.Location = new System.Drawing.Point(21, 75);
            this.labelWebsite.Name = "labelWebsite";
            this.labelWebsite.Size = new System.Drawing.Size(58, 19);
            this.labelWebsite.TabIndex = 24;
            this.labelWebsite.Text = "Website";
            // 
            // textBoxWebsite
            // 
            this.textBoxWebsite.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxWebsite.Location = new System.Drawing.Point(25, 98);
            this.textBoxWebsite.Name = "textBoxWebsite";
            this.textBoxWebsite.Size = new System.Drawing.Size(339, 26);
            this.textBoxWebsite.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(210, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 26;
            this.label2.Text = "Country ";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCity.Location = new System.Drawing.Point(24, 134);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(37, 19);
            this.labelCity.TabIndex = 25;
            this.labelCity.Text = "City ";
            // 
            // labelCompany
            // 
            this.labelCompany.AutoSize = true;
            this.labelCompany.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCompany.Location = new System.Drawing.Point(19, 10);
            this.labelCompany.Name = "labelCompany";
            this.labelCompany.Size = new System.Drawing.Size(78, 19);
            this.labelCompany.TabIndex = 18;
            this.labelCompany.Text = "Company *";
            // 
            // textBoxCompany
            // 
            this.textBoxCompany.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxCompany.Location = new System.Drawing.Point(22, 34);
            this.textBoxCompany.Name = "textBoxCompany";
            this.textBoxCompany.Size = new System.Drawing.Size(150, 26);
            this.textBoxCompany.TabIndex = 0;
            this.textBoxCompany.Text = "Deloitte";
            // 
            // textBoxCountry
            // 
            this.textBoxCountry.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textBoxCountry.Location = new System.Drawing.Point(214, 158);
            this.textBoxCountry.Name = "textBoxCountry";
            this.textBoxCountry.Size = new System.Drawing.Size(150, 26);
            this.textBoxCountry.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.comboBoxDoc);
            this.panel2.Controls.Add(this.comboBoxScore);
            this.panel2.Controls.Add(this.pickerApplied);
            this.panel2.Controls.Add(this.buttonRemoveDoc);
            this.panel2.Controls.Add(this.labelScore);
            this.panel2.Controls.Add(this.listBoxDocuments);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.comboBoxStatus);
            this.panel2.Controls.Add(this.buttonSelectDoc);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.labelIndustry);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.labelPlatform);
            this.panel2.Controls.Add(this.labelEndDate);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(763, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(370, 466);
            this.panel2.TabIndex = 46;
            // 
            // comboBoxDoc
            // 
            this.comboBoxDoc.FormattingEnabled = true;
            this.comboBoxDoc.Location = new System.Drawing.Point(32, 180);
            this.comboBoxDoc.Name = "comboBoxDoc";
            this.comboBoxDoc.Size = new System.Drawing.Size(304, 28);
            this.comboBoxDoc.TabIndex = 43;
            this.comboBoxDoc.SelectedIndexChanged += new System.EventHandler(this.comboBoxDoc_Select);
            // 
            // comboBoxScore
            // 
            this.comboBoxScore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxScore.FormattingEnabled = true;
            this.comboBoxScore.Items.AddRange(new object[] {
            "",
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBoxScore.Location = new System.Drawing.Point(32, 105);
            this.comboBoxScore.Name = "comboBoxScore";
            this.comboBoxScore.Size = new System.Drawing.Size(150, 28);
            this.comboBoxScore.TabIndex = 42;
            // 
            // pickerApplied
            // 
            this.pickerApplied.Checked = false;
            this.pickerApplied.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pickerApplied.Location = new System.Drawing.Point(186, 36);
            this.pickerApplied.Name = "pickerApplied";
            this.pickerApplied.ShowCheckBox = true;
            this.pickerApplied.Size = new System.Drawing.Size(150, 26);
            this.pickerApplied.TabIndex = 41;
            this.pickerApplied.Value = new System.DateTime(2025, 5, 25, 0, 0, 0, 0);
            // 
            // buttonRemoveDoc
            // 
            this.buttonRemoveDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoveDoc.Location = new System.Drawing.Point(188, 385);
            this.buttonRemoveDoc.Name = "buttonRemoveDoc";
            this.buttonRemoveDoc.Size = new System.Drawing.Size(151, 38);
            this.buttonRemoveDoc.TabIndex = 38;
            this.buttonRemoveDoc.Text = "Remove";
            this.buttonRemoveDoc.UseVisualStyleBackColor = true;
            this.buttonRemoveDoc.Click += new System.EventHandler(this.buttonRemoveDoc_Click);
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.Location = new System.Drawing.Point(28, 81);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(56, 19);
            this.labelScore.TabIndex = 33;
            this.labelScore.Text = "Interest";
            // 
            // listBoxDocuments
            // 
            this.listBoxDocuments.FormattingEnabled = true;
            this.listBoxDocuments.ItemHeight = 20;
            this.listBoxDocuments.Location = new System.Drawing.Point(32, 235);
            this.listBoxDocuments.Name = "listBoxDocuments";
            this.listBoxDocuments.Size = new System.Drawing.Size(306, 144);
            this.listBoxDocuments.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 19);
            this.label4.TabIndex = 31;
            this.label4.Text = "Documents";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "",
            "Saved",
            "Applied",
            "No-Response",
            "Rejected",
            "Accepted",
            "Offered"});
            this.comboBoxStatus.Location = new System.Drawing.Point(32, 36);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(150, 28);
            this.comboBoxStatus.TabIndex = 30;
            // 
            // buttonSelectDoc
            // 
            this.buttonSelectDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelectDoc.Location = new System.Drawing.Point(29, 385);
            this.buttonSelectDoc.Name = "buttonSelectDoc";
            this.buttonSelectDoc.Size = new System.Drawing.Size(153, 38);
            this.buttonSelectDoc.TabIndex = 29;
            this.buttonSelectDoc.Text = "New Document";
            this.buttonSelectDoc.UseVisualStyleBackColor = true;
            this.buttonSelectDoc.Click += new System.EventHandler(this.buttonSelectDoc_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(184, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 19);
            this.label8.TabIndex = 28;
            this.label8.Text = "Applied Date ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 19);
            this.label7.TabIndex = 22;
            this.label7.Text = "Status ";
            // 
            // labelIndustry
            // 
            this.labelIndustry.AutoSize = true;
            this.labelIndustry.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIndustry.Location = new System.Drawing.Point(-87, 227);
            this.labelIndustry.Name = "labelIndustry";
            this.labelIndustry.Size = new System.Drawing.Size(63, 19);
            this.labelIndustry.TabIndex = 27;
            this.labelIndustry.Text = "Industry:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 26);
            this.label3.TabIndex = 7;
            // 
            // labelPlatform
            // 
            this.labelPlatform.AutoSize = true;
            this.labelPlatform.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlatform.Location = new System.Drawing.Point(-91, 24);
            this.labelPlatform.Name = "labelPlatform";
            this.labelPlatform.Size = new System.Drawing.Size(65, 19);
            this.labelPlatform.TabIndex = 22;
            this.labelPlatform.Text = "Platform:";
            // 
            // labelEndDate
            // 
            this.labelEndDate.AutoSize = true;
            this.labelEndDate.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEndDate.Location = new System.Drawing.Point(-91, 157);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(82, 19);
            this.labelEndDate.TabIndex = 20;
            this.labelEndDate.Text = "Expiry Date:";
            // 
            // pickerOpen
            // 
            this.pickerOpen.Checked = false;
            this.pickerOpen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pickerOpen.Location = new System.Drawing.Point(378, 34);
            this.pickerOpen.Name = "pickerOpen";
            this.pickerOpen.ShowCheckBox = true;
            this.pickerOpen.Size = new System.Drawing.Size(150, 26);
            this.pickerOpen.TabIndex = 40;
            this.pickerOpen.Value = new System.DateTime(2025, 5, 25, 0, 0, 0, 0);
            // 
            // labelOpenDate
            // 
            this.labelOpenDate.AutoSize = true;
            this.labelOpenDate.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOpenDate.Location = new System.Drawing.Point(377, 14);
            this.labelOpenDate.Name = "labelOpenDate";
            this.labelOpenDate.Size = new System.Drawing.Size(76, 19);
            this.labelOpenDate.TabIndex = 33;
            this.labelOpenDate.Text = "Open Date";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.comboBoxSalary);
            this.panel1.Controls.Add(this.pickerStart);
            this.panel1.Controls.Add(this.pickerOpen);
            this.panel1.Controls.Add(this.labelOpenDate);
            this.panel1.Controls.Add(this.comboBoxWorkMode);
            this.panel1.Controls.Add(this.labelWorkMode);
            this.panel1.Controls.Add(this.labelStartDate);
            this.panel1.Controls.Add(this.labelSalary);
            this.panel1.Controls.Add(this.labelJobTitle);
            this.panel1.Controls.Add(this.textBoxJobTitle);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(19, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(712, 143);
            this.panel1.TabIndex = 45;
            // 
            // comboBoxSalary
            // 
            this.comboBoxSalary.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSalary.FormattingEnabled = true;
            this.comboBoxSalary.Items.AddRange(new object[] {
            "",
            "Unpaid / Volunteer  ",
            "Under $30k  ",
            "$30k – $40k  ",
            "$40k – $50k  ",
            "$50k – $60k  ",
            "$60k – $70k  ",
            "$70k – $80k  ",
            "$80k – $90k  ",
            "$90k – $100k  ",
            "$100k – $120k  ",
            "$120k – $150k  ",
            "$150k+"});
            this.comboBoxSalary.Location = new System.Drawing.Point(381, 103);
            this.comboBoxSalary.Name = "comboBoxSalary";
            this.comboBoxSalary.Size = new System.Drawing.Size(150, 28);
            this.comboBoxSalary.TabIndex = 41;
            // 
            // pickerStart
            // 
            this.pickerStart.Checked = false;
            this.pickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pickerStart.Location = new System.Drawing.Point(208, 103);
            this.pickerStart.Name = "pickerStart";
            this.pickerStart.ShowCheckBox = true;
            this.pickerStart.Size = new System.Drawing.Size(150, 26);
            this.pickerStart.TabIndex = 39;
            this.pickerStart.UseWaitCursor = true;
            this.pickerStart.Value = new System.DateTime(2025, 5, 25, 19, 50, 57, 0);
            // 
            // comboBoxWorkMode
            // 
            this.comboBoxWorkMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxWorkMode.FormattingEnabled = true;
            this.comboBoxWorkMode.Items.AddRange(new object[] {
            "",
            "Office",
            "Flexible",
            "Remote",
            "Hybrid"});
            this.comboBoxWorkMode.Location = new System.Drawing.Point(19, 103);
            this.comboBoxWorkMode.Name = "comboBoxWorkMode";
            this.comboBoxWorkMode.Size = new System.Drawing.Size(150, 28);
            this.comboBoxWorkMode.TabIndex = 31;
            // 
            // labelWorkMode
            // 
            this.labelWorkMode.AutoSize = true;
            this.labelWorkMode.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWorkMode.Location = new System.Drawing.Point(15, 83);
            this.labelWorkMode.Name = "labelWorkMode";
            this.labelWorkMode.Size = new System.Drawing.Size(82, 19);
            this.labelWorkMode.TabIndex = 21;
            this.labelWorkMode.Text = "Work Mode";
            // 
            // labelStartDate
            // 
            this.labelStartDate.AutoSize = true;
            this.labelStartDate.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStartDate.Location = new System.Drawing.Point(204, 81);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(72, 19);
            this.labelStartDate.TabIndex = 19;
            this.labelStartDate.Text = "Start Date";
            // 
            // labelSalary
            // 
            this.labelSalary.AutoSize = true;
            this.labelSalary.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSalary.Location = new System.Drawing.Point(377, 81);
            this.labelSalary.Name = "labelSalary";
            this.labelSalary.Size = new System.Drawing.Size(46, 19);
            this.labelSalary.TabIndex = 17;
            this.labelSalary.Text = "Salary";
            // 
            // labelJobTitle
            // 
            this.labelJobTitle.AutoSize = true;
            this.labelJobTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJobTitle.Location = new System.Drawing.Point(15, 14);
            this.labelJobTitle.Name = "labelJobTitle";
            this.labelJobTitle.Size = new System.Drawing.Size(69, 19);
            this.labelJobTitle.TabIndex = 16;
            this.labelJobTitle.Text = "Job Title *";
            // 
            // textBoxJobTitle
            // 
            this.textBoxJobTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxJobTitle.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxJobTitle.Location = new System.Drawing.Point(19, 36);
            this.textBoxJobTitle.Name = "textBoxJobTitle";
            this.textBoxJobTitle.Size = new System.Drawing.Size(339, 26);
            this.textBoxJobTitle.TabIndex = 3;
            this.textBoxJobTitle.Text = "Graduate Consultant";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 26);
            this.label1.TabIndex = 7;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.White;
            this.buttonCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonCancel.CausesValidation = false;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonCancel.Location = new System.Drawing.Point(763, 556);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(182, 44);
            this.buttonCancel.TabIndex = 44;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonCreateNew
            // 
            this.buttonCreateNew.BackColor = System.Drawing.Color.White;
            this.buttonCreateNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateNew.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonCreateNew.Location = new System.Drawing.Point(951, 555);
            this.buttonCreateNew.Name = "buttonCreateNew";
            this.buttonCreateNew.Size = new System.Drawing.Size(182, 44);
            this.buttonCreateNew.TabIndex = 42;
            this.buttonCreateNew.Text = "Save";
            this.buttonCreateNew.UseVisualStyleBackColor = false;
            this.buttonCreateNew.Click += new System.EventHandler(this.buttonCreateNew_Click);
            // 
            // FormNewApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1152, 617);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonCreateNew);
            this.Controls.Add(this.labelNewApp);
            this.Name = "FormNewApplication";
            this.Text = "ApplyFlow";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialogSelectDoc;
        private System.Windows.Forms.Label labelNewApp;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelExpiryDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxURL;
        private System.Windows.Forms.Label labelURL;
        private System.Windows.Forms.TextBox textBoxPlatform;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonRemoveIndustry;
        private System.Windows.Forms.Button buttonAddIndustry;
        private System.Windows.Forms.TextBox textBoxIndustry;
        private System.Windows.Forms.ListBox listBoxIndustryList;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelEmployerIndustry;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.Label labelWebsite;
        private System.Windows.Forms.TextBox textBoxWebsite;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelCompany;
        private System.Windows.Forms.TextBox textBoxCompany;
        private System.Windows.Forms.TextBox textBoxCountry;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonRemoveDoc;
        private System.Windows.Forms.ListBox listBoxDocuments;
        private System.Windows.Forms.Label labelOpenDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Button buttonSelectDoc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelIndustry;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelPlatform;
        private System.Windows.Forms.Label labelEndDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.ComboBox comboBoxWorkMode;
        private System.Windows.Forms.Label labelWorkMode;
        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.Label labelSalary;
        private System.Windows.Forms.Label labelJobTitle;
        private System.Windows.Forms.TextBox textBoxJobTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonCreateNew;
        private System.Windows.Forms.DateTimePicker pickerStart;
        private System.Windows.Forms.DateTimePicker pickerApplied;
        private System.Windows.Forms.DateTimePicker pickerOpen;
        private System.Windows.Forms.DateTimePicker pickerExpiry;
        private System.Windows.Forms.ComboBox comboBoxScore;
        private System.Windows.Forms.ComboBox comboBoxSalary;
        private System.Windows.Forms.ComboBox comboBoxIndustry;
        private System.Windows.Forms.ComboBox comboBoxDoc;
    }
}