
namespace ApplicationUI
{
    partial class AppointmentForm
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.apptEndTimeLabel = new System.Windows.Forms.Label();
            this.apptStartTimeLabel = new System.Windows.Forms.Label();
            this.custDetailsLink = new System.Windows.Forms.LinkLabel();
            this.apptEndTimeSelection = new System.Windows.Forms.DateTimePicker();
            this.apptStartTimeSelection = new System.Windows.Forms.DateTimePicker();
            this.apptTypeText = new System.Windows.Forms.TextBox();
            this.apptTypeLabel = new System.Windows.Forms.Label();
            this.custDropDownLabel = new System.Windows.Forms.Label();
            this.custDropDown = new System.Windows.Forms.ComboBox();
            this.headerLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.userDropDown = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(158, 319);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(86, 32);
            this.cancelButton.TabIndex = 43;
            this.cancelButton.Text = "CANCEL";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(54, 319);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(86, 32);
            this.saveButton.TabIndex = 42;
            this.saveButton.Text = "SAVE";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // apptEndTimeLabel
            // 
            this.apptEndTimeLabel.AutoSize = true;
            this.apptEndTimeLabel.Location = new System.Drawing.Point(38, 248);
            this.apptEndTimeLabel.Name = "apptEndTimeLabel";
            this.apptEndTimeLabel.Size = new System.Drawing.Size(120, 13);
            this.apptEndTimeLabel.TabIndex = 41;
            this.apptEndTimeLabel.Text = "Appointment End Time :";
            // 
            // apptStartTimeLabel
            // 
            this.apptStartTimeLabel.AutoSize = true;
            this.apptStartTimeLabel.Location = new System.Drawing.Point(38, 200);
            this.apptStartTimeLabel.Name = "apptStartTimeLabel";
            this.apptStartTimeLabel.Size = new System.Drawing.Size(123, 13);
            this.apptStartTimeLabel.TabIndex = 40;
            this.apptStartTimeLabel.Text = "Appointment Start Time :";
            // 
            // custDetailsLink
            // 
            this.custDetailsLink.AutoSize = true;
            this.custDetailsLink.Location = new System.Drawing.Point(192, 56);
            this.custDetailsLink.Name = "custDetailsLink";
            this.custDetailsLink.Size = new System.Drawing.Size(72, 13);
            this.custDetailsLink.TabIndex = 39;
            this.custDetailsLink.TabStop = true;
            this.custDetailsLink.Text = "Customer Info";
            this.custDetailsLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.custDetailsLink_LinkClicked);
            // 
            // apptEndTimeSelection
            // 
            this.apptEndTimeSelection.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.apptEndTimeSelection.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.apptEndTimeSelection.Location = new System.Drawing.Point(52, 266);
            this.apptEndTimeSelection.Name = "apptEndTimeSelection";
            this.apptEndTimeSelection.Size = new System.Drawing.Size(200, 20);
            this.apptEndTimeSelection.TabIndex = 38;
            // 
            // apptStartTimeSelection
            // 
            this.apptStartTimeSelection.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.apptStartTimeSelection.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.apptStartTimeSelection.Location = new System.Drawing.Point(52, 218);
            this.apptStartTimeSelection.Name = "apptStartTimeSelection";
            this.apptStartTimeSelection.Size = new System.Drawing.Size(200, 20);
            this.apptStartTimeSelection.TabIndex = 37;
            // 
            // apptTypeText
            // 
            this.apptTypeText.Location = new System.Drawing.Point(52, 170);
            this.apptTypeText.Name = "apptTypeText";
            this.apptTypeText.Size = new System.Drawing.Size(200, 20);
            this.apptTypeText.TabIndex = 36;
            // 
            // apptTypeLabel
            // 
            this.apptTypeLabel.AutoSize = true;
            this.apptTypeLabel.Location = new System.Drawing.Point(38, 152);
            this.apptTypeLabel.Name = "apptTypeLabel";
            this.apptTypeLabel.Size = new System.Drawing.Size(99, 13);
            this.apptTypeLabel.TabIndex = 35;
            this.apptTypeLabel.Text = "Appointment Type :";
            // 
            // custDropDownLabel
            // 
            this.custDropDownLabel.AutoSize = true;
            this.custDropDownLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custDropDownLabel.Location = new System.Drawing.Point(35, 56);
            this.custDropDownLabel.Name = "custDropDownLabel";
            this.custDropDownLabel.Size = new System.Drawing.Size(62, 13);
            this.custDropDownLabel.TabIndex = 34;
            this.custDropDownLabel.Text = "Customer :";
            // 
            // custDropDown
            // 
            this.custDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.custDropDown.FormattingEnabled = true;
            this.custDropDown.Location = new System.Drawing.Point(52, 72);
            this.custDropDown.Name = "custDropDown";
            this.custDropDown.Size = new System.Drawing.Size(200, 21);
            this.custDropDown.TabIndex = 33;
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(61, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(177, 25);
            this.headerLabel.TabIndex = 32;
            this.headerLabel.Text = "Appointment Data";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Consultant :";
            // 
            // userDropDown
            // 
            this.userDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.userDropDown.FormattingEnabled = true;
            this.userDropDown.Location = new System.Drawing.Point(52, 121);
            this.userDropDown.Name = "userDropDown";
            this.userDropDown.Size = new System.Drawing.Size(200, 21);
            this.userDropDown.TabIndex = 44;
            // 
            // AppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(299, 376);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userDropDown);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.apptEndTimeLabel);
            this.Controls.Add(this.apptStartTimeLabel);
            this.Controls.Add(this.custDetailsLink);
            this.Controls.Add(this.apptEndTimeSelection);
            this.Controls.Add(this.apptStartTimeSelection);
            this.Controls.Add(this.apptTypeText);
            this.Controls.Add(this.apptTypeLabel);
            this.Controls.Add(this.custDropDownLabel);
            this.Controls.Add(this.custDropDown);
            this.Controls.Add(this.headerLabel);
            this.Name = "AppointmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Appointment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label apptEndTimeLabel;
        private System.Windows.Forms.Label apptStartTimeLabel;
        private System.Windows.Forms.LinkLabel custDetailsLink;
        private System.Windows.Forms.DateTimePicker apptEndTimeSelection;
        private System.Windows.Forms.DateTimePicker apptStartTimeSelection;
        private System.Windows.Forms.TextBox apptTypeText;
        private System.Windows.Forms.Label apptTypeLabel;
        private System.Windows.Forms.Label custDropDownLabel;
        private System.Windows.Forms.ComboBox custDropDown;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox userDropDown;
    }
}