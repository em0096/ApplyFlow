namespace ApplyFlow
{
    partial class FormHome
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
            this.dataGridApplications = new System.Windows.Forms.DataGridView();
            this.buttonNewApplication = new System.Windows.Forms.Button();
            this.User = new System.Windows.Forms.Label();
            this.Avg = new System.Windows.Forms.Label();
            this.SPD = new System.Windows.Forms.Label();
            this.listBoxCountry = new System.Windows.Forms.ListBox();
            this.listBoxInterviews = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxCityNow = new System.Windows.Forms.ListBox();
            this.CurrentJobs = new System.Windows.Forms.Label();
            this.CountJobsUser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridApplications)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridApplications
            // 
            this.dataGridApplications.AllowUserToAddRows = false;
            this.dataGridApplications.AllowUserToDeleteRows = false;
            this.dataGridApplications.AllowUserToResizeColumns = false;
            this.dataGridApplications.AllowUserToResizeRows = false;
            this.dataGridApplications.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridApplications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridApplications.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridApplications.Location = new System.Drawing.Point(628, 92);
            this.dataGridApplications.Name = "dataGridApplications";
            this.dataGridApplications.Size = new System.Drawing.Size(461, 427);
            this.dataGridApplications.TabIndex = 0;
            this.dataGridApplications.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridApplications_CellContentClick);
            // 
            // buttonNewApplication
            // 
            this.buttonNewApplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewApplication.Location = new System.Drawing.Point(877, 23);
            this.buttonNewApplication.Name = "buttonNewApplication";
            this.buttonNewApplication.Size = new System.Drawing.Size(212, 51);
            this.buttonNewApplication.TabIndex = 1;
            this.buttonNewApplication.Text = "New Application";
            this.buttonNewApplication.UseVisualStyleBackColor = true;
            this.buttonNewApplication.Click += new System.EventHandler(this.buttonNewApplication_Click);
            // 
            // User
            // 
            this.User.AutoSize = true;
            this.User.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User.Location = new System.Drawing.Point(12, 9);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(85, 20);
            this.User.TabIndex = 2;
            this.User.Text = "UserName";
            // 
            // Avg
            // 
            this.Avg.AutoSize = true;
            this.Avg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Avg.Location = new System.Drawing.Point(19, 49);
            this.Avg.Name = "Avg";
            this.Avg.Size = new System.Drawing.Size(158, 25);
            this.Avg.TabIndex = 3;
            this.Avg.Text = " :Average Salary";
            // 
            // SPD
            // 
            this.SPD.AutoSize = true;
            this.SPD.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SPD.Location = new System.Drawing.Point(306, 49);
            this.SPD.Name = "SPD";
            this.SPD.Size = new System.Drawing.Size(246, 25);
            this.SPD.TabIndex = 5;
            this.SPD.Text = "Sucess, Pending, Declined";
            // 
            // listBoxCountry
            // 
            this.listBoxCountry.FormattingEnabled = true;
            this.listBoxCountry.Location = new System.Drawing.Point(308, 244);
            this.listBoxCountry.Name = "listBoxCountry";
            this.listBoxCountry.Size = new System.Drawing.Size(283, 108);
            this.listBoxCountry.TabIndex = 6;
            this.listBoxCountry.SelectedIndexChanged += new System.EventHandler(this.listBoxCountry_SelectedIndexChanged);
            // 
            // listBoxInterviews
            // 
            this.listBoxInterviews.FormattingEnabled = true;
            this.listBoxInterviews.Location = new System.Drawing.Point(16, 372);
            this.listBoxInterviews.Name = "listBoxInterviews";
            this.listBoxInterviews.Size = new System.Drawing.Size(575, 147);
            this.listBoxInterviews.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Upcoming Interviews";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(308, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Count of Jobs per City, All Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Count of currently Available Jobs per City";
            // 
            // listBoxCityNow
            // 
            this.listBoxCityNow.FormattingEnabled = true;
            this.listBoxCityNow.Location = new System.Drawing.Point(16, 244);
            this.listBoxCityNow.Name = "listBoxCityNow";
            this.listBoxCityNow.Size = new System.Drawing.Size(283, 108);
            this.listBoxCityNow.TabIndex = 11;
            // 
            // CurrentJobs
            // 
            this.CurrentJobs.AutoSize = true;
            this.CurrentJobs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentJobs.Location = new System.Drawing.Point(19, 92);
            this.CurrentJobs.Name = "CurrentJobs";
            this.CurrentJobs.Size = new System.Drawing.Size(187, 25);
            this.CurrentJobs.TabIndex = 12;
            this.CurrentJobs.Text = " :Currently Available";
            // 
            // CountJobsUser
            // 
            this.CountJobsUser.AutoSize = true;
            this.CountJobsUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountJobsUser.Location = new System.Drawing.Point(19, 127);
            this.CountJobsUser.Name = "CountJobsUser";
            this.CountJobsUser.Size = new System.Drawing.Size(197, 25);
            this.CountJobsUser.TabIndex = 13;
            this.CountJobsUser.Text = "# of Jobs Appiled For";
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1123, 558);
            this.Controls.Add(this.CountJobsUser);
            this.Controls.Add(this.CurrentJobs);
            this.Controls.Add(this.listBoxCityNow);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxInterviews);
            this.Controls.Add(this.listBoxCountry);
            this.Controls.Add(this.SPD);
            this.Controls.Add(this.Avg);
            this.Controls.Add(this.User);
            this.Controls.Add(this.buttonNewApplication);
            this.Controls.Add(this.dataGridApplications);
            this.Name = "FormHome";
            this.Text = "ApplyFlow";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridApplications)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridApplications;
        private System.Windows.Forms.Button buttonNewApplication;
        private System.Windows.Forms.Label User;
        private System.Windows.Forms.Label Avg;
        private System.Windows.Forms.Label SPD;
        private System.Windows.Forms.ListBox listBoxCountry;
        private System.Windows.Forms.ListBox listBoxInterviews;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxCityNow;
        private System.Windows.Forms.Label CurrentJobs;
        private System.Windows.Forms.Label CountJobsUser;
    }
}