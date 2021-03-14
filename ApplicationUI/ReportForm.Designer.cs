
namespace ApplicationUI
{
    partial class ReportForm
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
            this.exitButton = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.reportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consultantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apptTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apptStartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apptEndDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(218, 270);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(86, 32);
            this.exitButton.TabIndex = 27;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
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
            this.consultantDataGridViewTextBoxColumn,
            this.custNameDataGridViewTextBoxColumn,
            this.apptTypeDataGridViewTextBoxColumn,
            this.apptStartDataGridViewTextBoxColumn,
            this.apptEndDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.reportBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(64, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(384, 252);
            this.dataGridView.TabIndex = 28;
            // 
            // reportBindingSource
            // 
            this.reportBindingSource.DataSource = typeof(ApplicationLibrary.Models.Report);
            // 
            // consultantDataGridViewTextBoxColumn
            // 
            this.consultantDataGridViewTextBoxColumn.DataPropertyName = "Consultant";
            this.consultantDataGridViewTextBoxColumn.HeaderText = "Consultant";
            this.consultantDataGridViewTextBoxColumn.Name = "consultantDataGridViewTextBoxColumn";
            this.consultantDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.apptStartDataGridViewTextBoxColumn.HeaderText = "Start";
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
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(509, 311);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.exitButton);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Report";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn consultantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apptTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apptStartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apptEndDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource reportBindingSource;
    }
}