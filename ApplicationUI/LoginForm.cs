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
    public partial class LoginForm : Form
    {
        public User currentUser;
        public string inValidLogin = "Incorrect Login Information.";
        public string usernameEmpty = "Username Empty";
        public string passwordEmpty = "Password Empty";

        public LoginForm()
        {
            InitializeComponent();

            if (CultureInfo.CurrentUICulture.LCID == 1031)
            {
                headerLabel.Text = "Anmeldung Bilden";
                usernameLabel.Text = "NUTZERNAME :";
                passwordLabel.Text = "PASSWORT :";
                loginButton.Text = "ANMELDEN";
                exitButton.Text = "AUSFAHRT";
                inValidLogin = "Inkorrekte Anmeldung Information";
                usernameEmpty = "Benutzername leer";
                passwordEmpty = "Passwort leer";
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (FormValid())
            {
                User userModel = new User
                {
                    Username = usernameText.Text,
                    Password = passwordText.Text
                };
                GlobalConfig.Connection.Authenticate(userModel);
                if (userModel.Active == 1)
                {
                    User currentUser = userModel;
                    DashboardForm dashboard = new DashboardForm(currentUser);
                    this.Hide();
                    dashboard.Show();
                }
            }
            else
            {
                MessageBox.Show(inValidLogin);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private bool FormValid()
        {
            bool output = true;

            if (String.IsNullOrEmpty(usernameText.Text))
            {
                MessageBox.Show(usernameEmpty);
                output = false;
            }

            if (String.IsNullOrEmpty(passwordText.Text))
            {
                MessageBox.Show(passwordEmpty);
                output = false;
            }
            return output;
        }
    }
}
