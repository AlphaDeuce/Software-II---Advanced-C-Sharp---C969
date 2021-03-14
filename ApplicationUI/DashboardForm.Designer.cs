
namespace ApplicationUI
{
    partial class DashboardForm
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
            this.components = new System.ComponentModel.Container();
            this.logoutButton = new System.Windows.Forms.Button();
            this.calendarLabel = new System.Windows.Forms.Label();
            this.monthRadioButton = new System.Windows.Forms.RadioButton();
            this.weekRadioButton = new System.Windows.Forms.RadioButton();
            this.reportGroupBox = new System.Windows.Forms.GroupBox();
            this.custReportButton = new System.Windows.Forms.Button();
            this.userReportButton = new System.Windows.Forms.Button();
            this.monthReportButton = new System.Windows.Forms.Button();
            this.apptGroupBox = new System.Windows.Forms.GroupBox();
            this.apptModifyButton = new System.Windows.Forms.Button();
            this.apptRemoveButton = new System.Windows.Forms.Button();
            this.apptCreateButton = new System.Windows.Forms.Button();
            this.custGroupBox = new System.Windows.Forms.GroupBox();
            this.custModifyButton = new System.Windows.Forms.Button();
            this.custRemoveButton = new System.Windows.Forms.Button();
            this.custCreateButton = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.custNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apptTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apptStartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apptEndDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportGroupBox.SuspendLayout();
            this.apptGroupBox.SuspendLayout();
            this.custGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // logoutButton
            // 
            this.logoutButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.Location = new System.Drawing.Point(683, 6);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(86, 32);
            this.logoutButton.TabIndex = 26;
            this.logoutButton.Text = "LOGOUT";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // calendarLabel
            // 
            this.calendarLabel.AutoSize = true;
            this.calendarLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendarLabel.Location = new System.Drawing.Point(89, 45);
            this.calendarLabel.Name = "calendarLabel";
            this.calendarLabel.Size = new System.Drawing.Size(236, 25);
            this.calendarLabel.TabIndex = 25;
            this.calendarLabel.Text = "Scheduled Appointments";
            // 
            // monthRadioButton
            // 
            this.monthRadioButton.AutoSize = true;
            this.monthRadioButton.Location = new System.Drawing.Point(217, 336);
            this.monthRadioButton.Name = "monthRadioButton";
            this.monthRadioButton.Size = new System.Drawing.Size(55, 17);
            this.monthRadioButton.TabIndex = 24;
            this.monthRadioButton.Text = "Month";
            this.monthRadioButton.UseVisualStyleBackColor = true;
            this.monthRadioButton.CheckedChanged += new System.EventHandler(this.monthRadioButton_CheckedChanged);
            // 
            // weekRadioButton
            // 
            this.weekRadioButton.AutoSize = true;
            this.weekRadioButton.Checked = true;
            this.weekRadioButton.Location = new System.Drawing.Point(128, 336);
            this.weekRadioButton.Name = "weekRadioButton";
            this.weekRadioButton.Size = new System.Drawing.Size(54, 17);
            this.weekRadioButton.TabIndex = 23;
            this.weekRadioButton.TabStop = true;
            this.weekRadioButton.Text = "Week";
            this.weekRadioButton.UseVisualStyleBackColor = true;
            // 
            // reportGroupBox
            // 
            this.reportGroupBox.Controls.Add(this.custReportButton);
            this.reportGroupBox.Controls.Add(this.userReportButton);
            this.reportGroupBox.Controls.Add(this.monthReportButton);
            this.reportGroupBox.Location = new System.Drawing.Point(423, 255);
            this.reportGroupBox.Name = "reportGroupBox";
            this.reportGroupBox.Size = new System.Drawing.Size(346, 99);
            this.reportGroupBox.TabIndex = 22;
            this.reportGroupBox.TabStop = false;
            this.reportGroupBox.Text = "Reports";
            // 
            // custReportButton
            // 
            this.custReportButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custReportButton.Location = new System.Drawing.Point(222, 33);
            this.custReportButton.Name = "custReportButton";
            this.custReportButton.Size = new System.Drawing.Size(86, 42);
            this.custReportButton.TabIndex = 15;
            this.custReportButton.Text = "Appt By\r\nCustomer";
            this.custReportButton.UseVisualStyleBackColor = true;
            this.custReportButton.Click += new System.EventHandler(this.custReportButton_Click);
            // 
            // userReportButton
            // 
            this.userReportButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userReportButton.Location = new System.Drawing.Point(130, 33);
            this.userReportButton.Name = "userReportButton";
            this.userReportButton.Size = new System.Drawing.Size(86, 42);
            this.userReportButton.TabIndex = 14;
            this.userReportButton.Text = "Appt By\r\n Consultant";
            this.userReportButton.UseVisualStyleBackColor = true;
            this.userReportButton.Click += new System.EventHandler(this.userReportButton_Click);
            // 
            // monthReportButton
            // 
            this.monthReportButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthReportButton.Location = new System.Drawing.Point(38, 33);
            this.monthReportButton.Name = "monthReportButton";
            this.monthReportButton.Size = new System.Drawing.Size(86, 42);
            this.monthReportButton.TabIndex = 13;
            this.monthReportButton.Text = "Appt By \r\nMonth";
            this.monthReportButton.UseVisualStyleBackColor = true;
            this.monthReportButton.Click += new System.EventHandler(this.monthReportButton_Click);
            // 
            // apptGroupBox
            // 
            this.apptGroupBox.Controls.Add(this.apptModifyButton);
            this.apptGroupBox.Controls.Add(this.apptRemoveButton);
            this.apptGroupBox.Controls.Add(this.apptCreateButton);
            this.apptGroupBox.Location = new System.Drawing.Point(423, 150);
            this.apptGroupBox.Name = "apptGroupBox";
            this.apptGroupBox.Size = new System.Drawing.Size(346, 99);
            this.apptGroupBox.TabIndex = 21;
            this.apptGroupBox.TabStop = false;
            this.apptGroupBox.Text = "Appointments";
            // 
            // apptModifyButton
            // 
            this.apptModifyButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apptModifyButton.Location = new System.Drawing.Point(222, 33);
            this.apptModifyButton.Name = "apptModifyButton";
            this.apptModifyButton.Size = new System.Drawing.Size(86, 32);
            this.apptModifyButton.TabIndex = 12;
            this.apptModifyButton.Text = "MODIFY";
            this.apptModifyButton.UseVisualStyleBackColor = true;
            this.apptModifyButton.Click += new System.EventHandler(this.apptModifyButton_Click);
            // 
            // apptRemoveButton
            // 
            this.apptRemoveButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apptRemoveButton.Location = new System.Drawing.Point(130, 33);
            this.apptRemoveButton.Name = "apptRemoveButton";
            this.apptRemoveButton.Size = new System.Drawing.Size(86, 32);
            this.apptRemoveButton.TabIndex = 11;
            this.apptRemoveButton.Text = "REMOVE";
            this.apptRemoveButton.UseVisualStyleBackColor = true;
            this.apptRemoveButton.Click += new System.EventHandler(this.apptRemoveButton_Click);
            // 
            // apptCreateButton
            // 
            this.apptCreateButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apptCreateButton.Location = new System.Drawing.Point(38, 33);
            this.apptCreateButton.Name = "apptCreateButton";
            this.apptCreateButton.Size = new System.Drawing.Size(86, 32);
            this.apptCreateButton.TabIndex = 10;
            this.apptCreateButton.Text = "CREATE";
            this.apptCreateButton.UseVisualStyleBackColor = true;
            this.apptCreateButton.Click += new System.EventHandler(this.apptCreateButton_Click);
            // 
            // custGroupBox
            // 
            this.custGroupBox.Controls.Add(this.custModifyButton);
            this.custGroupBox.Controls.Add(this.custRemoveButton);
            this.custGroupBox.Controls.Add(this.custCreateButton);
            this.custGroupBox.Location = new System.Drawing.Point(423, 45);
            this.custGroupBox.Name = "custGroupBox";
            this.custGroupBox.Size = new System.Drawing.Size(346, 99);
            this.custGroupBox.TabIndex = 20;
            this.custGroupBox.TabStop = false;
            this.custGroupBox.Text = "Customers";
            // 
            // custModifyButton
            // 
            this.custModifyButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custModifyButton.Location = new System.Drawing.Point(222, 33);
            this.custModifyButton.Name = "custModifyButton";
            this.custModifyButton.Size = new System.Drawing.Size(86, 32);
            this.custModifyButton.TabIndex = 9;
            this.custModifyButton.Text = "MODIFY";
            this.custModifyButton.UseVisualStyleBackColor = true;
            this.custModifyButton.Click += new System.EventHandler(this.custModifyButton_Click);
            // 
            // custRemoveButton
            // 
            this.custRemoveButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custRemoveButton.Location = new System.Drawing.Point(130, 33);
            this.custRemoveButton.Name = "custRemoveButton";
            this.custRemoveButton.Size = new System.Drawing.Size(86, 32);
            this.custRemoveButton.TabIndex = 8;
            this.custRemoveButton.Text = "REMOVE";
            this.custRemoveButton.UseVisualStyleBackColor = true;
            this.custRemoveButton.Click += new System.EventHandler(this.custRemoveButton_Click);
            // 
            // custCreateButton
            // 
            this.custCreateButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custCreateButton.Location = new System.Drawing.Point(38, 33);
            this.custCreateButton.Name = "custCreateButton";
            this.custCreateButton.Size = new System.Drawing.Size(86, 32);
            this.custCreateButton.TabIndex = 7;
            this.custCreateButton.Text = "CREATE";
            this.custCreateButton.UseVisualStyleBackColor = true;
            this.custCreateButton.Click += new System.EventHandler(this.custCreateButton_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.custNameDataGridViewTextBoxColumn,
            this.apptTypeDataGridViewTextBoxColumn,
            this.apptStartDataGridViewTextBoxColumn,
            this.apptEndDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.reportBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(15, 78);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(384, 252);
            this.dataGridView.TabIndex = 19;
            // 
            // custNameDataGridViewTextBoxColumn
            // 
            this.custNameDataGridViewTextBoxColumn.DataPropertyName = "CustName";
            this.custNameDataGridViewTextBoxColumn.HeaderText = "Customer";
            this.custNameDataGridViewTextBoxColumn.Name = "custNameDataGridViewTextBoxColumn";
            this.custNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apptTypeDataGridViewTextBoxColumn
            // 
            this.apptTypeDataGridViewTextBoxColumn.DataPropertyName = "ApptType";
            this.apptTypeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.apptTypeDataGridViewTextBoxColumn.Name = "apptTypeDataGridViewTextBoxColumn";
            this.apptTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apptStartDataGridViewTextBoxColumn
            // 
            this.apptStartDataGridViewTextBoxColumn.DataPropertyName = "ApptStart";
            this.apptStartDataGridViewTextBoxColumn.HeaderText = "Begin";
            this.apptStartDataGridViewTextBoxColumn.Name = "apptStartDataGridViewTextBoxColumn";
            this.apptStartDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apptEndDataGridViewTextBoxColumn
            // 
            this.apptEndDataGridViewTextBoxColumn.DataPropertyName = "ApptEnd";
            this.apptEndDataGridViewTextBoxColumn.HeaderText = "End";
            this.apptEndDataGridViewTextBoxColumn.Name = "apptEndDataGridViewTextBoxColumn";
            this.apptEndDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reportBindingSource
            // 
            this.reportBindingSource.DataSource = typeof(ApplicationLibrary.Models.Report);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.calendarLabel);
            this.Controls.Add(this.monthRadioButton);
            this.Controls.Add(this.weekRadioButton);
            this.Controls.Add(this.reportGroupBox);
            this.Controls.Add(this.apptGroupBox);
            this.Controls.Add(this.custGroupBox);
            this.Controls.Add(this.dataGridView);
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DashboardForm_FormClosing);
            this.VisibleChanged += new System.EventHandler(this.DashboardForm_VisibleChanged);
            this.reportGroupBox.ResumeLayout(false);
            this.apptGroupBox.ResumeLayout(false);
            this.custGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Label calendarLabel;
        private System.Windows.Forms.RadioButton monthRadioButton;
        private System.Windows.Forms.RadioButton weekRadioButton;
        private System.Windows.Forms.GroupBox reportGroupBox;
        private System.Windows.Forms.Button custReportButton;
        private System.Windows.Forms.Button userReportButton;
        private System.Windows.Forms.Button monthReportButton;
        private System.Windows.Forms.GroupBox apptGroupBox;
        private System.Windows.Forms.Button apptModifyButton;
        private System.Windows.Forms.Button apptRemoveButton;
        private System.Windows.Forms.Button apptCreateButton;
        private System.Windows.Forms.GroupBox custGroupBox;
        private System.Windows.Forms.Button custModifyButton;
        private System.Windows.Forms.Button custRemoveButton;
        private System.Windows.Forms.Button custCreateButton;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.BindingSource reportBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn custNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apptTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apptStartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apptEndDataGridViewTextBoxColumn;
    }
}