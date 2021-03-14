using ApplicationLibrary;
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
    public partial class ReportForm : Form
    {
        public BindingList<Report> Report { get; set; } = new BindingList<Report>();

        public ReportForm(ReportType report, int reportId)
        {
            InitializeComponent();

            switch (report)
            {
                case ReportType.Customer:
                    this.Text = "Customer Report";
                    List<Appointment> custAppointments = ApplicationLibrary.GlobalConfig.Connection.GetCustomerAppts(reportId);
                    int i = 0;
                    foreach (var appt in custAppointments)
                    {
                        Report.Add(new Report(custAppointments[i].UserName, custAppointments[i].CustomerName, custAppointments[i].Type, custAppointments[i].Start.ToLocalTime().ToString(), custAppointments[i].End.ToLocalTime().ToString()));
                        i++;
                    }
                    break;
                case ReportType.User:
                    this.Text = "User Report";
                    List<Appointment> userAppointments = ApplicationLibrary.GlobalConfig.Connection.GetAppointments(reportId);
                    int i2 = 0;
                    foreach (var appt in userAppointments)
                    {
                        Report.Add(new Report(userAppointments[i2].UserName, userAppointments[i2].CustomerName, userAppointments[i2].Type, userAppointments[i2].Start.ToLocalTime().ToString(), userAppointments[i2].End.ToLocalTime().ToString()));
                        i2++;
                    }
                    break;
                case ReportType.Month:
                    this.Text = "Month Report";
                    DateTime currentTime = DateTime.UtcNow;
                    int monthOfYear = (int)currentTime.Month;
                    DateTime thisMonthStart = new DateTime(currentTime.Year, currentTime.Month, 1);
                    DateTime twelveMonthsOut = thisMonthStart.AddMonths(12).AddDays(-1);
                    
                    List<Appointment> monthAppointments = ApplicationLibrary.GlobalConfig.Connection.GetAllAppointments();
                    int i3 = 0;
                    foreach (var appt in monthAppointments)
                    {
                        if (monthAppointments[i3].Start.ToLocalTime() >= thisMonthStart && monthAppointments[i3].End.ToLocalTime() <= twelveMonthsOut)
                        {
                            if (monthAppointments[i3].Start.Month == reportId)
                            {
                                Report.Add(new Report(monthAppointments[i3].UserName, monthAppointments[i3].CustomerName, monthAppointments[i3].Type, monthAppointments[i3].Start.ToLocalTime().ToString(), monthAppointments[i3].End.ToLocalTime().ToString()));
                            }
                        }
                        i3++;
                    }
                    break;
                default:
                    break;
            }

            dataGridView.RowHeadersVisible = false;
            dataGridView.DataSource = Report;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
