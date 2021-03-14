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
    public partial class AppointmentForm : Form
    {
        public List<Customer> customers = GlobalConfig.Connection.GetCustomerNames();
        public List<User> users = GlobalConfig.Connection.GetUsers();
        public bool modify = false;
        private User activeUser;
        private int appointmentId;


        public AppointmentForm(Appointment appointmentModel, User userModel)
        {
            InitializeComponent();
            activeUser = userModel;
            appointmentId = appointmentModel.AppointmentId;

            custDropDown.DataSource = customers;
            custDropDown.Refresh();
            custDropDown.DisplayMember = "CustomerName";
            custDropDown.ValueMember = "CustomerId";
            custDropDown.Text = appointmentModel.CustomerName;

            userDropDown.DataSource = users;
            userDropDown.Refresh();
            userDropDown.DisplayMember = "UserName";
            userDropDown.ValueMember = "UserId";
            userDropDown.SelectedIndex = appointmentModel.UserId - 1;

            apptTypeText.Text = appointmentModel.Type;
            apptStartTimeSelection.Value = appointmentModel.Start.ToLocalTime();
            apptEndTimeSelection.Value = appointmentModel.End.ToLocalTime();

            modify = true;

        }

        public AppointmentForm(User userModel)
        {
            InitializeComponent();

            activeUser = userModel;

            custDropDown.DataSource = customers;
            custDropDown.Refresh();
            custDropDown.DisplayMember = "CustomerName";
            custDropDown.ValueMember = "CustomerId";
            custDropDown.SelectedIndex = -1;

            userDropDown.DataSource = users;
            userDropDown.Refresh();
            userDropDown.DisplayMember = "UserName";
            userDropDown.ValueMember = "UserId";
            userDropDown.SelectedIndex = -1;


        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (FormValid())
            {
                Appointment appointmentModel = FillModel();
                if (!modify)
                {

                    GlobalConfig.Connection.CreateAppointment(appointmentModel, activeUser);
                    if (MessageBox.Show("New 'Appointment' Record Saved Successfully.\n Create Another?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        FormClear();
                    }
                    else
                    {
                        this.Close();
                    }
                }
                else
                {
                    GlobalConfig.Connection.ModifyAppointment(appointmentModel, activeUser);
                    if (MessageBox.Show("'Appointment' Record Saved Successfully.\n Modify Another?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        this.Hide();
                        RecordSelectForm recordSelect = new RecordSelectForm(RecordType.Appointment, RecordAction.Modify, activeUser);
                        recordSelect.ShowDialog();
                    }
                    else
                    {
                        this.Owner.Close();
                        this.Close();
                    }
                }
            }
        }

        private bool FormValid()
        {
            DateTime apptStart = apptStartTimeSelection.Value;
            DateTime apptEnd = apptEndTimeSelection.Value;
            int userId = (int)userDropDown.SelectedValue;

            bool output = true;

            if (String.IsNullOrEmpty(apptTypeText.Text))
            {
                output = false;
            }

            if (!GlobalConfig.Connection.TimeSlotAvail(apptStart, apptEnd, userId))
            {
                output = false;
            }
            return output;
        }

        private Appointment FillModel()
        {
            Appointment appointmentModel = new Appointment
            {
                AppointmentId = appointmentId,
                CustomerId = (int)custDropDown.SelectedValue,
                UserId = (int)userDropDown.SelectedValue,
                Type = apptTypeText.Text,
                Start = apptStartTimeSelection.Value,
                End = apptEndTimeSelection.Value
            };
        return appointmentModel;
        }

        private void FormClear()
        {
            custDropDown.SelectedIndex = -1;
            userDropDown.SelectedIndex = -1;
            apptTypeText.Text = "";
            apptStartTimeSelection.Value = DateTime.Now;
            apptEndTimeSelection.Value = DateTime.Now;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void custDetailsLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (custDropDown.SelectedIndex > -1)
            {
                Customer customerModel = new Customer { CustomerId = (int)custDropDown.SelectedValue };
                GlobalConfig.Connection.GetCustomer(customerModel);
                CustomerForm customer = new CustomerForm(customerModel, activeUser) { Owner = this };
                customer.ShowDialog();
            }
        }
    }
}
