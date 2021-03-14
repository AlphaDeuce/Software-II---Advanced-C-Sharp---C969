using ApplicationLibrary;
using ApplicationLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationUI
{
    public partial class RecordSelectForm : Form 
    {
        public List<Customer> customers = GlobalConfig.Connection.GetCustomerNames();
        public List<Appointment> appointments = GlobalConfig.Connection.GetAllAppointments();
        public List<User> users = GlobalConfig.Connection.GetUsers();

        private User activeUser;
        private readonly RecordAction Action;
        private readonly RecordType Type;
        
        public RecordSelectForm(RecordType record, RecordAction action, User currentUser)
        {
            InitializeComponent();
            activeUser = currentUser;
            Type = record;
            Action = action;
            

            switch (record)
            {
                case RecordType.Customer:
                    headerLabel.Text = "Select Customer";
                    RefreshList(customers, "CustomerName", "CustomerId");
                    break;
                case RecordType.Appointment:
                    headerLabel.Text = "Select Appointment";
                    RefreshList(appointments, "ApptSelectDisplay", "AppointmentId");
                    break;
                case RecordType.User:
                    headerLabel.Text = "Select Consultant";
                    RefreshList(users, "Username", "userId");
                    break;
                case RecordType.Month:
                    headerLabel.Text = "Select Month";
                    string[] names = DateTimeFormatInfo.CurrentInfo.MonthNames;
                    Array.Resize(ref names, 12);
                    selectionBox.Items.AddRange(names);
                    break;
            }
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            switch (Type)
            {
                case RecordType.Customer:
                    Customer customerModel = new Customer { CustomerId = (int)selectionBox.SelectedValue };
                    GlobalConfig.Connection.GetCustomer(customerModel);
                    switch (Action)
                    {
                        case RecordAction.Modify:
                            CustomerForm customer = new CustomerForm(customerModel, activeUser) { Owner = this };
                            customer.ShowDialog();
                            this.Close();
                            break;
                        case RecordAction.Drop:
                            GlobalConfig.Connection.DropCustomer(customerModel);
                            if (MessageBox.Show($"{customerModel.CustomerName} Removed From The Database Successfully.\n Remove Another?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                selectionBox.DataSource = null;
                                // TODO -- LAMBDA EXPRESSION to remove the old record from the previous populated 'customers' list
                                customers.RemoveAll(x => x.CustomerName == customerModel.CustomerName);
                                RefreshList(customers, "CustomerName", "CustomerId");
                            }
                            else
                            {
                                this.Owner.Show();
                                this.Close();
                            }
                            break;
                        case RecordAction.Report:
                            ReportForm custReport = new ReportForm(ReportType.Customer,  customerModel.CustomerId);
                            custReport.ShowDialog();
                            this.Close();
                            break;                        
                        default:
                            break;
                    }
                    break;
                case RecordType.Appointment:
                    Appointment appointmentModel = new Appointment { AppointmentId = (int)selectionBox.SelectedValue };
                    GlobalConfig.Connection.GetAppointment(appointmentModel);
                    switch (Action)
                    {
                        case RecordAction.Modify:
                            AppointmentForm appointment = new AppointmentForm(appointmentModel, activeUser) { Owner = this }; 
                            appointment.ShowDialog();
                            this.Close();
                            break;
                        case RecordAction.Drop:
                            GlobalConfig.Connection.DropAppointment(appointmentModel);
                            if (MessageBox.Show($"{appointmentModel.ApptSelectDisplay} Removed From The Database Successfully.\n Remove Another?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                selectionBox.DataSource = null;
                                // TODO -- LAMBDA EXPRESSION to remove the old record from the previous populated 'appointment' list
                                appointments.RemoveAll(x => x.AppointmentId == appointmentModel.AppointmentId);
                                RefreshList(appointments, "ApptSelectDisplay", "AppointmentId");
                            }
                            else
                            {
                                this.Owner.Show();
                                this.Close();
                            }
                            break;
                        default:
                            break;
                    }
                    break;
                case RecordType.User:
                    User userModel = new User { UserId = (int)selectionBox.SelectedValue };
                    GlobalConfig.Connection.GetUser(userModel);
                    ReportForm userReport = new ReportForm(ReportType.User, userModel.UserId);
                    userReport.ShowDialog();
                    this.Close();
                    break;
                case RecordType.Month:
                    ReportForm monthReport = new ReportForm(ReportType.Month, (int)selectionBox.SelectedIndex + 1);
                    monthReport.ShowDialog();
                    this.Close();
                    break;
                       
            } 
        }
        /// <summary>
        /// Fills selection combobox datasource with list of objects of (customer/appointment/user) models 
        /// </summary>
        /// <param name="ds"></param>
        /// <param name="display"></param>
        /// <param name="value"></param>
        private void RefreshList(object ds, string display, string value)
        {
            selectionBox.DataSource = ds;
            selectionBox.Refresh();
            selectionBox.DisplayMember = display;
            selectionBox.ValueMember = value;
            selectionBox.SelectedIndex = -1;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
