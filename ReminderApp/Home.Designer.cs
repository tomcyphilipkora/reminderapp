namespace ReminderApp
{
    partial class Home
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
            this.lblHeading = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.cbHour = new System.Windows.Forms.ComboBox();
            this.cbMin = new System.Windows.Forms.ComboBox();
            this.cbAMPM = new System.Windows.Forms.ComboBox();
            this.lblRemHeading = new System.Windows.Forms.Label();
            this.lblBody = new System.Windows.Forms.Label();
            this.txtHeading = new System.Windows.Forms.TextBox();
            this.txtBody = new System.Windows.Forms.TextBox();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvReminderDetails = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReminderDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.Red;
            this.lblHeading.Location = new System.Drawing.Point(12, 9);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(742, 36);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "REMINDER APP";
            this.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnAddNew);
            this.panel1.Controls.Add(this.txtBody);
            this.panel1.Controls.Add(this.txtHeading);
            this.panel1.Controls.Add(this.lblBody);
            this.panel1.Controls.Add(this.lblRemHeading);
            this.panel1.Controls.Add(this.cbAMPM);
            this.panel1.Controls.Add(this.cbMin);
            this.panel1.Controls.Add(this.cbHour);
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.dtpDate);
            this.panel1.Location = new System.Drawing.Point(18, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(736, 161);
            this.panel1.TabIndex = 1;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(91, 14);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(143, 20);
            this.dtpDate.TabIndex = 0;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(55, 20);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Date";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(260, 20);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(30, 13);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "Time";
            // 
            // cbHour
            // 
            this.cbHour.FormattingEnabled = true;
            this.cbHour.Location = new System.Drawing.Point(296, 12);
            this.cbHour.Name = "cbHour";
            this.cbHour.Size = new System.Drawing.Size(45, 21);
            this.cbHour.TabIndex = 3;
            // 
            // cbMin
            // 
            this.cbMin.FormattingEnabled = true;
            this.cbMin.Location = new System.Drawing.Point(347, 12);
            this.cbMin.Name = "cbMin";
            this.cbMin.Size = new System.Drawing.Size(45, 21);
            this.cbMin.TabIndex = 4;
            // 
            // cbAMPM
            // 
            this.cbAMPM.FormattingEnabled = true;
            this.cbAMPM.Items.AddRange(new object[] {
            ""});
            this.cbAMPM.Location = new System.Drawing.Point(398, 12);
            this.cbAMPM.Name = "cbAMPM";
            this.cbAMPM.Size = new System.Drawing.Size(45, 21);
            this.cbAMPM.TabIndex = 5;
            // 
            // lblRemHeading
            // 
            this.lblRemHeading.AutoSize = true;
            this.lblRemHeading.Location = new System.Drawing.Point(38, 51);
            this.lblRemHeading.Name = "lblRemHeading";
            this.lblRemHeading.Size = new System.Drawing.Size(47, 13);
            this.lblRemHeading.TabIndex = 6;
            this.lblRemHeading.Text = "Heading";
            // 
            // lblBody
            // 
            this.lblBody.AutoSize = true;
            this.lblBody.Location = new System.Drawing.Point(54, 102);
            this.lblBody.Name = "lblBody";
            this.lblBody.Size = new System.Drawing.Size(31, 13);
            this.lblBody.TabIndex = 7;
            this.lblBody.Text = "Body";
            // 
            // txtHeading
            // 
            this.txtHeading.Location = new System.Drawing.Point(92, 51);
            this.txtHeading.Name = "txtHeading";
            this.txtHeading.Size = new System.Drawing.Size(351, 20);
            this.txtHeading.TabIndex = 8;
            // 
            // txtBody
            // 
            this.txtBody.Location = new System.Drawing.Point(92, 95);
            this.txtBody.Multiline = true;
            this.txtBody.Name = "txtBody";
            this.txtBody.Size = new System.Drawing.Size(351, 54);
            this.txtBody.TabIndex = 9;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(548, 28);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 23);
            this.btnAddNew.TabIndex = 10;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(548, 73);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(548, 117);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvReminderDetails
            // 
            this.dgvReminderDetails.AllowUserToAddRows = false;
            this.dgvReminderDetails.AllowUserToDeleteRows = false;
            this.dgvReminderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReminderDetails.Location = new System.Drawing.Point(18, 262);
            this.dgvReminderDetails.Name = "dgvReminderDetails";
            this.dgvReminderDetails.ReadOnly = true;
            this.dgvReminderDetails.Size = new System.Drawing.Size(736, 208);
            this.dgvReminderDetails.TabIndex = 2;
            this.dgvReminderDetails.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvReminderDetails_RowHeaderMouseClick);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 482);
            this.Controls.Add(this.dgvReminderDetails);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblHeading);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReminderDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblBody;
        private System.Windows.Forms.Label lblRemHeading;
        private System.Windows.Forms.ComboBox cbAMPM;
        private System.Windows.Forms.ComboBox cbMin;
        private System.Windows.Forms.ComboBox cbHour;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.TextBox txtBody;
        private System.Windows.Forms.TextBox txtHeading;
        private System.Windows.Forms.DataGridView dgvReminderDetails;
    }
}