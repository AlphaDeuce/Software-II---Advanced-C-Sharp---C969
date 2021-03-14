
namespace ApplicationUI
{
    partial class CustomerForm
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
            this.headerLabel = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.TextBox();
            this.phoneText = new System.Windows.Forms.TextBox();
            this.custNameLabel = new System.Windows.Forms.Label();
            this.custPhoneLabel = new System.Windows.Forms.Label();
            this.custAddressGroupBox = new System.Windows.Forms.GroupBox();
            this.address1Text = new System.Windows.Forms.TextBox();
            this.custAddress1Label = new System.Windows.Forms.Label();
            this.countryText = new System.Windows.Forms.TextBox();
            this.postalCodeText = new System.Windows.Forms.TextBox();
            this.cityText = new System.Windows.Forms.TextBox();
            this.address2Text = new System.Windows.Forms.TextBox();
            this.custCountryLabel = new System.Windows.Forms.Label();
            this.custZipLabel = new System.Windows.Forms.Label();
            this.custCityLabel = new System.Windows.Forms.Label();
            this.custAddress2Label = new System.Windows.Forms.Label();
            this.yesRadioButton = new System.Windows.Forms.RadioButton();
            this.noRadioButton = new System.Windows.Forms.RadioButton();
            this.custActiveLabel = new System.Windows.Forms.Label();
            this.custAddressGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(176, 330);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(86, 32);
            this.cancelButton.TabIndex = 39;
            this.cancelButton.Text = "CANCEL";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(72, 330);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(86, 32);
            this.saveButton.TabIndex = 38;
            this.saveButton.Text = "SAVE";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(98, 21);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(144, 25);
            this.headerLabel.TabIndex = 40;
            this.headerLabel.Text = "Customer Data";
            // 
            // nameText
            // 
            this.nameText.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameText.Location = new System.Drawing.Point(117, 67);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(148, 22);
            this.nameText.TabIndex = 33;
            // 
            // phoneText
            // 
            this.phoneText.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneText.Location = new System.Drawing.Point(117, 95);
            this.phoneText.Name = "phoneText";
            this.phoneText.Size = new System.Drawing.Size(148, 22);
            this.phoneText.TabIndex = 34;
            // 
            // custNameLabel
            // 
            this.custNameLabel.AutoSize = true;
            this.custNameLabel.Location = new System.Drawing.Point(60, 73);
            this.custNameLabel.Name = "custNameLabel";
            this.custNameLabel.Size = new System.Drawing.Size(42, 13);
            this.custNameLabel.TabIndex = 32;
            this.custNameLabel.Text = "Name :";
            // 
            // custPhoneLabel
            // 
            this.custPhoneLabel.AutoSize = true;
            this.custPhoneLabel.Location = new System.Drawing.Point(56, 101);
            this.custPhoneLabel.Name = "custPhoneLabel";
            this.custPhoneLabel.Size = new System.Drawing.Size(46, 13);
            this.custPhoneLabel.TabIndex = 31;
            this.custPhoneLabel.Text = "Phone :";
            // 
            // custAddressGroupBox
            // 
            this.custAddressGroupBox.Controls.Add(this.address1Text);
            this.custAddressGroupBox.Controls.Add(this.custAddress1Label);
            this.custAddressGroupBox.Controls.Add(this.countryText);
            this.custAddressGroupBox.Controls.Add(this.postalCodeText);
            this.custAddressGroupBox.Controls.Add(this.cityText);
            this.custAddressGroupBox.Controls.Add(this.address2Text);
            this.custAddressGroupBox.Controls.Add(this.custCountryLabel);
            this.custAddressGroupBox.Controls.Add(this.custZipLabel);
            this.custAddressGroupBox.Controls.Add(this.custCityLabel);
            this.custAddressGroupBox.Controls.Add(this.custAddress2Label);
            this.custAddressGroupBox.Location = new System.Drawing.Point(29, 121);
            this.custAddressGroupBox.Name = "custAddressGroupBox";
            this.custAddressGroupBox.Padding = new System.Windows.Forms.Padding(0);
            this.custAddressGroupBox.Size = new System.Drawing.Size(276, 168);
            this.custAddressGroupBox.TabIndex = 35;
            this.custAddressGroupBox.TabStop = false;
            this.custAddressGroupBox.Text = "Address";
            // 
            // address1Text
            // 
            this.address1Text.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address1Text.Location = new System.Drawing.Point(86, 20);
            this.address1Text.Name = "address1Text";
            this.address1Text.Size = new System.Drawing.Size(150, 22);
            this.address1Text.TabIndex = 4;
            // 
            // custAddress1Label
            // 
            this.custAddress1Label.AutoSize = true;
            this.custAddress1Label.Location = new System.Drawing.Point(23, 20);
            this.custAddress1Label.Name = "custAddress1Label";
            this.custAddress1Label.Size = new System.Drawing.Size(43, 13);
            this.custAddress1Label.TabIndex = 0;
            this.custAddress1Label.Text = "Line 1 :";
            // 
            // countryText
            // 
            this.countryText.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryText.Location = new System.Drawing.Point(86, 130);
            this.countryText.Name = "countryText";
            this.countryText.Size = new System.Drawing.Size(150, 22);
            this.countryText.TabIndex = 8;
            // 
            // postalCodeText
            // 
            this.postalCodeText.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postalCodeText.Location = new System.Drawing.Point(86, 102);
            this.postalCodeText.Name = "postalCodeText";
            this.postalCodeText.Size = new System.Drawing.Size(150, 22);
            this.postalCodeText.TabIndex = 7;
            // 
            // cityText
            // 
            this.cityText.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityText.Location = new System.Drawing.Point(86, 74);
            this.cityText.Name = "cityText";
            this.cityText.Size = new System.Drawing.Size(150, 22);
            this.cityText.TabIndex = 6;
            // 
            // address2Text
            // 
            this.address2Text.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address2Text.Location = new System.Drawing.Point(86, 46);
            this.address2Text.Name = "address2Text";
            this.address2Text.Size = new System.Drawing.Size(150, 22);
            this.address2Text.TabIndex = 5;
            // 
            // custCountryLabel
            // 
            this.custCountryLabel.AutoSize = true;
            this.custCountryLabel.Location = new System.Drawing.Point(17, 130);
            this.custCountryLabel.Name = "custCountryLabel";
            this.custCountryLabel.Size = new System.Drawing.Size(54, 13);
            this.custCountryLabel.TabIndex = 0;
            this.custCountryLabel.Text = "Country :";
            // 
            // custZipLabel
            // 
            this.custZipLabel.AutoSize = true;
            this.custZipLabel.Location = new System.Drawing.Point(38, 102);
            this.custZipLabel.Name = "custZipLabel";
            this.custZipLabel.Size = new System.Drawing.Size(29, 13);
            this.custZipLabel.TabIndex = 0;
            this.custZipLabel.Text = "Zip :";
            // 
            // custCityLabel
            // 
            this.custCityLabel.AutoSize = true;
            this.custCityLabel.Location = new System.Drawing.Point(35, 74);
            this.custCityLabel.Name = "custCityLabel";
            this.custCityLabel.Size = new System.Drawing.Size(32, 13);
            this.custCityLabel.TabIndex = 0;
            this.custCityLabel.Text = "City :";
            // 
            // custAddress2Label
            // 
            this.custAddress2Label.AutoSize = true;
            this.custAddress2Label.Location = new System.Drawing.Point(23, 46);
            this.custAddress2Label.Name = "custAddress2Label";
            this.custAddress2Label.Size = new System.Drawing.Size(43, 13);
            this.custAddress2Label.TabIndex = 0;
            this.custAddress2Label.Text = "Line 2 :";
            // 
            // yesRadioButton
            // 
            this.yesRadioButton.AutoSize = true;
            this.yesRadioButton.Checked = true;
            this.yesRadioButton.Location = new System.Drawing.Point(142, 298);
            this.yesRadioButton.Name = "yesRadioButton";
            this.yesRadioButton.Size = new System.Drawing.Size(40, 17);
            this.yesRadioButton.TabIndex = 36;
            this.yesRadioButton.TabStop = true;
            this.yesRadioButton.Text = "Yes";
            this.yesRadioButton.UseVisualStyleBackColor = true;
            // 
            // noRadioButton
            // 
            this.noRadioButton.AutoSize = true;
            this.noRadioButton.Location = new System.Drawing.Point(191, 298);
            this.noRadioButton.Name = "noRadioButton";
            this.noRadioButton.Size = new System.Drawing.Size(40, 17);
            this.noRadioButton.TabIndex = 37;
            this.noRadioButton.Text = "No";
            this.noRadioButton.UseVisualStyleBackColor = true;
            // 
            // custActiveLabel
            // 
            this.custActiveLabel.AutoSize = true;
            this.custActiveLabel.Location = new System.Drawing.Point(57, 302);
            this.custActiveLabel.Name = "custActiveLabel";
            this.custActiveLabel.Size = new System.Drawing.Size(43, 13);
            this.custActiveLabel.TabIndex = 41;
            this.custActiveLabel.Text = "Active :";
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(334, 381);
            this.Controls.Add(this.custActiveLabel);
            this.Controls.Add(this.noRadioButton);
            this.Controls.Add(this.yesRadioButton);
            this.Controls.Add(this.custAddressGroupBox);
            this.Controls.Add(this.custPhoneLabel);
            this.Controls.Add(this.custNameLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.phoneText);
            this.Controls.Add(this.nameText);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CustomerForm";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Customer";
            this.custAddressGroupBox.ResumeLayout(false);
            this.custAddressGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.TextBox phoneText;
        private System.Windows.Forms.Label custNameLabel;
        private System.Windows.Forms.Label custPhoneLabel;
        private System.Windows.Forms.GroupBox custAddressGroupBox;
        private System.Windows.Forms.TextBox address1Text;
        private System.Windows.Forms.Label custAddress1Label;
        private System.Windows.Forms.TextBox countryText;
        private System.Windows.Forms.TextBox postalCodeText;
        private System.Windows.Forms.TextBox cityText;
        private System.Windows.Forms.TextBox address2Text;
        private System.Windows.Forms.Label custCountryLabel;
        private System.Windows.Forms.Label custZipLabel;
        private System.Windows.Forms.Label custCityLabel;
        private System.Windows.Forms.Label custAddress2Label;
        private System.Windows.Forms.RadioButton yesRadioButton;
        private System.Windows.Forms.RadioButton noRadioButton;
        private System.Windows.Forms.Label custActiveLabel;
    }
}