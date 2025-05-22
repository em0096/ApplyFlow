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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridApplications)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridApplications
            // 
            this.dataGridApplications.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridApplications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridApplications.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridApplications.Location = new System.Drawing.Point(43, 92);
            this.dataGridApplications.Name = "dataGridApplications";
            this.dataGridApplications.Size = new System.Drawing.Size(1046, 427);
            this.dataGridApplications.TabIndex = 0;
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
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1123, 558);
            this.Controls.Add(this.buttonNewApplication);
            this.Controls.Add(this.dataGridApplications);
            this.Name = "FormHome";
            this.Text = "ApplyFlow";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridApplications)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridApplications;
        private System.Windows.Forms.Button buttonNewApplication;
    }
}