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
    public partial class CustomerForm : Form
    {
        public bool modify = false;
        public int customerId, addressId, cityId, countryId;
        private User activeUser;

        public CustomerForm(User currentUser)
        {
            InitializeComponent();

            activeUser = currentUser;
        }

        public CustomerForm(Customer customerModel, User currentUser)
        {
            
            InitializeComponent();

            activeUser = currentUser;
            modify = true;

            nameText.Text = customerModel.CustomerName;
            phoneText.Text = customerModel.Phone;
            address1Text.Text = customerModel.Address;
            address2Text.Text = customerModel.Address2;
            cityText.Text = customerModel.City;
            postalCodeText.Text = customerModel.PostalCode;
            countryText.Text = customerModel.Country;
            if (customerModel.Active == 1)
            {
                yesRadioButton.Checked = true;
            }
            else
            {
                noRadioButton.Checked = true;
            }
            customerId = customerModel.CustomerId;
            addressId = customerModel.AddressId;
            cityId = customerModel.CityId;
            countryId = customerModel.CountryId;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (FormValid())
            {
                Customer customerModel = FillModel();
                if (!modify)
                {

                    GlobalConfig.Connection.CreateCustomer(customerModel, activeUser);
                    if (MessageBox.Show("New 'Customer' Record Saved Successfully.\n Create Another?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
                    GlobalConfig.Connection.ModifyCustomer(customerModel, activeUser);
                    if (MessageBox.Show("'Customer' Record Saved Successfully.\n Modify Another?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        this.Hide();
                        RecordSelectForm recordSelect = new RecordSelectForm(RecordType.Customer, RecordAction.Modify, activeUser);
                        recordSelect.ShowDialog();
                    }
                    else
                    {
                        this.Owner.Close();
                        this.Close();
                    }
                }
                FormClear();
            }
            else
            {
                MessageBox.Show("Form Is Incomplete.", "Information");
            }
        }

        private void FormClear()
        {          
            // TODO -- LAMBDA EXPRESSIONS to reset form fields after record is saved
            Controls.OfType<TextBox>().ToList().ForEach(t => t.Text = string.Empty);
            custAddressGroupBox.Controls.OfType<TextBox>().ToList().ForEach(t => t.Text = string.Empty);
            yesRadioButton.Checked = true;
        }

        private Customer FillModel()
        {
            Customer customerModel = new Customer
            {
                CustomerName = nameText.Text,
                Phone = phoneText.Text,
                Address = address1Text.Text,
                Address2 = address2Text.Text,
                City = cityText.Text,
                PostalCode = postalCodeText.Text,
                Country = countryText.Text,
                CustomerId = customerId,
                AddressId = addressId,
                CityId = cityId,
                CountryId = countryId
            };
            if (yesRadioButton.Checked)
            {
                customerModel.Active = 1;
            }
            else
            {
                customerModel.Active = 0;
            }
            return customerModel;
        }

        private bool FormValid()
        {
            bool output = true;


            if (String.IsNullOrEmpty(nameText.Text))
            {
                output = false;
            }

            if (String.IsNullOrEmpty(phoneText.Text))
            {
                output = false;
            }

            if (String.IsNullOrEmpty(address1Text.Text))
            {
                output = false;
            }

            if (String.IsNullOrEmpty(cityText.Text))
            {
                output = false;
            }

            if (String.IsNullOrEmpty(postalCodeText.Text) || !postalCodeText.Text.All(char.IsDigit))
            {
                output = false;
            }

            if (String.IsNullOrEmpty(countryText.Text))
            {
                output = false;
            }

            return output;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }
    }
}
