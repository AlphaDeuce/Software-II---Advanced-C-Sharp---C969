using ApplicationLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationUI
{
    public partial class DashboardForm : Form
    {
        private User activeUser;

        public BindingList<Report> Report { get; set; }  = new BindingList<Report>();

        public DashboardForm(User currentUser)
        {
            InitializeComponent();
            activeUser = currentUser;
            LoadCalendar(weekRadioButton.Enabled);
            dataGridView.RowHeadersVisible = false;
            dataGridView.DataSource = Report;
            apptAlert();

        }

        private void custRemoveButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RecordSelectForm recordSelect = new RecordSelectForm(
                ApplicationLibrary.RecordType.Customer,
                ApplicationLibrary.RecordAction.Drop,
                activeUser) { Owner = this };
            recordSelect.ShowDialog();
            this.Show();
        }

        private void custModifyButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RecordSelectForm recordSelect = new RecordSelectForm(
                ApplicationLibrary.RecordType.Customer, 
                ApplicationLibrary.RecordAction.Modify,
                activeUser) { Owner = this };
            recordSelect.ShowDialog();
            this.Show();
        }

        private void custCreateButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerForm customer = new CustomerForm(activeUser) { Owner = this }; 
            customer.ShowDialog();
            this.Show();
        }

        private void DashboardForm_FormClosing(object sender, FormClosingEventArgs e)
        {
           if (e.CloseReason == CloseReason.UserClosing)
            {
                Environment.Exit(0);
            }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            this.Hide();
            login.Show();

        }

        private void monthRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Report.Clear();
            LoadCalendar(weekRadioButton.Checked);
        }

        public void LoadCalendar(bool week)
        {

            DateTime currentTime = DateTime.UtcNow;
            int dayOfWeek = (int)currentTime.DayOfWeek;
            DateTime thisWeekStart = currentTime.AddDays(-dayOfWeek);
            DateTime thisWeekEnd = currentTime.AddDays(7 - dayOfWeek);
            DateTime thisMonthStart = new DateTime(currentTime.Year, currentTime.Month, 1);
            DateTime thisMonthEnd = thisMonthStart.AddMonths(1).AddDays(-1);

            List<Appointment> appointments = ApplicationLibrary.GlobalConfig.Connection.GetAppointments(activeUser.UserId);        

            if (week)
            {
                int i = 0;
                foreach (var appt in appointments)
                {
                    if (appointments[i].Start.ToLocalTime() >= thisWeekStart && appointments[i].End.ToLocalTime() <= thisWeekEnd)
                    {
                        Report.Add(new Report(appointments[i].UserName, appointments[i].CustomerName, appointments[i].Type, appointments[i].Start.ToLocalTime().ToString(), appointments[i].End.ToLocalTime().ToString()));
                    }
                    i++;
                }
            }
            else
            {
                int i = 0;
                foreach (var appt in appointments)
                {
                    if (appointments[i].Start.ToLocalTime() >= thisMonthStart && appointments[i].End.ToLocalTime() <= thisMonthEnd)
                    {
                        Report.Add(new Report(appointments[i].UserName, appointments[i].CustomerName, appointments[i].Type, appointments[i].Start.ToLocalTime().ToString(), appointments[i].End.ToLocalTime().ToString()));
                    }
                    i++;
                }
            }






        }

        private void apptCreateButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AppointmentForm appointment = new AppointmentForm(activeUser) { Owner = this };
            appointment.ShowDialog();
            this.Show();
        }

        private void apptModifyButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RecordSelectForm recordSelect = new RecordSelectForm(
                ApplicationLibrary.RecordType.Appointment,
                ApplicationLibrary.RecordAction.Modify,
                activeUser) { Owner = this };
            recordSelect.ShowDialog();
            this.Show();
        }

        private void apptRemoveButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RecordSelectForm recordSelect = new RecordSelectForm(
                ApplicationLibrary.RecordType.Appointment,
                ApplicationLibrary.RecordAction.Drop,
                activeUser)
            { Owner = this };
            recordSelect.ShowDialog();
            this.Show();
        }

        // Event handler to refresh datagrid (calendar listing) everytime the window comes back
        private void DashboardForm_VisibleChanged(object sender, EventArgs e)
        {
            Report.Clear();
            LoadCalendar(weekRadioButton.Checked);
        }

        private void custReportButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RecordSelectForm recordSelect = new RecordSelectForm(
                ApplicationLibrary.RecordType.Customer,
                ApplicationLibrary.RecordAction.Report,
                activeUser)
            { Owner = this };
            recordSelect.ShowDialog();
            this.Show();
        }

        private void userReportButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RecordSelectForm recordSelect = new RecordSelectForm(
                ApplicationLibrary.RecordType.User,
                ApplicationLibrary.RecordAction.Report,
                activeUser)
            { Owner = this };
            recordSelect.ShowDialog();
            this.Show();
        }

        private void monthReportButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RecordSelectForm recordSelect = new RecordSelectForm(
                ApplicationLibrary.RecordType.Month,
                ApplicationLibrary.RecordAction.Report,
                activeUser)
            { Owner = this };
            recordSelect.ShowDialog();
            this.Show();
        }

        private void apptAlert()
        {
            for (int i = 0; i < Report.Count(); i++)
            {
                DateTime nextStart = Convert.ToDateTime(Report[i].ApptStart);
                TimeSpan nextAppt = nextStart.ToUniversalTime() - DateTime.UtcNow;
                if (nextAppt.TotalMinutes <= 15 && nextAppt.TotalMinutes > 1)
                {
                    MessageBox.Show($"Appointment with {Report[i].CustName} at {Report[i].ApptStart}.", "Alert");
                }
            }
        }



    }
}
