using ApplicationLibrary.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace ApplicationLibrary.DataAccess
{

    public class MySqlConnector : IDataConnection
    {

        /// <summary>
        /// Saves new customer record to database
        /// </summary>
        /// <param name="model"></param>
        /// <returns>Completes the 'Customer' model with information not provided by the CustomerForm</returns>
        public Customer CreateCustomer(Customer customerModel, User userModel)
        {
            using (MySqlConnection connection = OpenConnection())
            {
                // Create command line container for MySql Stored Procedure
                MySqlCommand cmd = new MySqlCommand("spCustomer_Insert", connection) { CommandType = CommandType.StoredProcedure };

                // Input values from CustomerForm as parameters for MySql Stored Procedure 
                cmd.Parameters.AddWithValue("@p_customerName", customerModel.CustomerName);
                cmd.Parameters.AddWithValue("@p_active", customerModel.Active);
                cmd.Parameters.AddWithValue("@p_address", customerModel.Address);
                cmd.Parameters.AddWithValue("@p_address2", customerModel.Address2);
                cmd.Parameters.AddWithValue("@p_city", customerModel.City);
                cmd.Parameters.AddWithValue("@p_postalCode", customerModel.PostalCode);
                cmd.Parameters.AddWithValue("@p_phone", customerModel.Phone);
                cmd.Parameters.AddWithValue("@p_country", customerModel.Country);
                cmd.Parameters.AddWithValue("@p_user", userModel.Username);

                // Identify variables that will be OUTPUT from MySql Stored Procedure
                cmd.Parameters.Add("?v_customerId", MySqlDbType.Int32);
                cmd.Parameters.Add("?v_addressId", MySqlDbType.Int32);
                cmd.Parameters.Add("?v_cityId", MySqlDbType.Int32);
                cmd.Parameters.Add("?v_countryId", MySqlDbType.Int32);

                // Define direction of OUTPUT values
                cmd.Parameters["?v_customerId"].Direction = ParameterDirection.Output;
                cmd.Parameters["?v_addressId"].Direction = ParameterDirection.Output;
                cmd.Parameters["?v_cityId"].Direction = ParameterDirection.Output;
                cmd.Parameters["?v_countryId"].Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();

                // Update model with Primary/Foreign Key values
                customerModel.CustomerId = (int)cmd.Parameters["?v_customerId"].Value;
                customerModel.AddressId = (int)cmd.Parameters["?v_addressId"].Value;
                customerModel.CityId = (int)cmd.Parameters["?v_cityId"].Value;
                customerModel.CountryId = (int)cmd.Parameters["?v_countryId"].Value;

            }

            return customerModel;
        }

        /// <summary>
        /// Retrieves customer record information from databse based on 'customerName'
        /// </summary>
        /// <param name="model"></param>
        /// <returns>Completes customer model with current data from database</returns>
        public Customer GetCustomer(Customer customerModel)
        {
            using (MySqlConnection connection = OpenConnection())
            {
                // Create command line container for MySql Stored Procedure
                MySqlCommand cmd = new MySqlCommand("spCustomer_Get", connection) { CommandType = CommandType.StoredProcedure };

                // Input values from CustomerForm as parameters for MySql Stored Procedure 
                cmd.Parameters.AddWithValue("@p_customerId", customerModel.CustomerId);


                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    // Update model with output data
                    customerModel.CustomerId = (int)dataReader["customerId"];
                    customerModel.CustomerName = dataReader["customerName"].ToString();
                    customerModel.Active = (bool)dataReader["active"] ? 1 : 0;
                    customerModel.Address = dataReader["address"].ToString();
                    customerModel.Address2 = dataReader["address2"].ToString();
                    customerModel.CityId = (int)dataReader["cityId"];
                    customerModel.PostalCode = dataReader["postalCode"].ToString();
                    customerModel.Phone = dataReader["phone"].ToString();
                    customerModel.CountryId = (int)dataReader["countryId"];
                    customerModel.City = dataReader["city"].ToString();
                    customerModel.Country = dataReader["country"].ToString();
                }
                dataReader.Close();
            }
            return customerModel;
        }

        /// <summary>
        /// Retrieves all rows in the customers table
        /// </summary>
        /// <returns>Populated list of customer models with customer name and customerId information</returns>
        public List<Customer> GetCustomerNames()
        {
            List<Customer> output = new List<Customer>();

            using (MySqlConnection connection = OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM customer", connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    Customer model = new Customer
                    {
                        CustomerId = (int)dataReader["customerId"],
                        CustomerName = dataReader["customerName"].ToString()
                    };
                    output.Add(model);
                }
                dataReader.Close();
            }
            return output;
        }

        /// <summary>
        /// Modify existing record in database using customerId as primary key
        /// </summary>
        /// <param name="model"></param>
        /// <returns>An unaltered customer model</returns>
        public Customer ModifyCustomer(Customer customerModel, User userModel)
        {
            using (MySqlConnection connection = OpenConnection())
            {
                // Create command line container for MySql Stored Procedure
                MySqlCommand cmd = new MySqlCommand("spCustomer_Modify", connection) { CommandType = CommandType.StoredProcedure };

                // Input values from CustomerForm as parameters for MySql Stored Procedure 
                cmd.Parameters.AddWithValue("@p_customerName", customerModel.CustomerName);
                cmd.Parameters.AddWithValue("@p_active", (byte)customerModel.Active);
                cmd.Parameters.AddWithValue("@p_address", customerModel.Address);
                cmd.Parameters.AddWithValue("@p_address2", customerModel.Address2);
                cmd.Parameters.AddWithValue("@p_city", customerModel.City);
                cmd.Parameters.AddWithValue("@p_postalCode", customerModel.PostalCode);
                cmd.Parameters.AddWithValue("@p_phone", customerModel.Phone);
                cmd.Parameters.AddWithValue("@p_country", customerModel.Country);
                cmd.Parameters.AddWithValue("@p_customerId", customerModel.CustomerId);
                cmd.Parameters.AddWithValue("@p_addressId", customerModel.AddressId);
                cmd.Parameters.AddWithValue("@p_cityId", customerModel.CityId);
                cmd.Parameters.AddWithValue("@p_countryId", customerModel.CountryId);
                cmd.Parameters.AddWithValue("@p_user", userModel.Username);

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }


            }

            return customerModel;
        }

        /// <summary>
        /// Remove customer record from database
        /// </summary>
        /// <param name="model"></param>
        /// <returns>An unaltered customer model</returns>
        public Customer DropCustomer(Customer model)
        {
            using (MySqlConnection connection = OpenConnection())
            {
                // Create command line container for MySql Stored Procedure
                MySqlCommand cmd = new MySqlCommand("spCustomer_Drop", connection) { CommandType = CommandType.StoredProcedure };

                // Input values from CustomerForm as parameters for MySql Stored Procedure 
                cmd.Parameters.AddWithValue("@p_customerId", model.CustomerId);
                cmd.Parameters.AddWithValue("@p_addressId", model.AddressId);
                cmd.Parameters.AddWithValue("@p_cityId", model.CityId);
                cmd.Parameters.AddWithValue("@p_countryId", model.CountryId);

                cmd.ExecuteNonQuery();
            }
            return model;
        }




        public Appointment CreateAppointment(Appointment appointmentModel, User userModel)
        {
            using (MySqlConnection connection = OpenConnection())
            {
                // Create command line container for MySql Stored Procedure
                MySqlCommand cmd = new MySqlCommand("spAppointment_Insert", connection) { CommandType = CommandType.StoredProcedure };

                // Input values from CustomerForm as parameters for MySql Stored Procedure 
                cmd.Parameters.AddWithValue("@p_currentUser", userModel.Username);
                cmd.Parameters.AddWithValue("@p_customerId", appointmentModel.CustomerId);
                cmd.Parameters.AddWithValue("@p_userId", appointmentModel.UserId);
                cmd.Parameters.AddWithValue("@p_type", appointmentModel.Type);
                cmd.Parameters.AddWithValue("@p_start", appointmentModel.Start.ToUniversalTime());
                cmd.Parameters.AddWithValue("@p_end", appointmentModel.End.ToUniversalTime());

                // Identify variables that will be OUTPUT from MySql Stored Procedure
                cmd.Parameters.Add("?v_appointmentId", MySqlDbType.Int32);

                // Define direction of OUTPUT values
                cmd.Parameters["?v_appointmentId"].Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();

                // Update model with Primary/Foreign Key values
                appointmentModel.AppointmentId = (int)cmd.Parameters["?v_appointmentId"].Value;
            }

            return appointmentModel;
        }

        public Appointment GetAppointment(Appointment appointmentModel)
        {
            using (MySqlConnection connection = OpenConnection())
            {
                // Create command line container for MySql Stored Procedure
                MySqlCommand cmd = new MySqlCommand("spAppointment_Get", connection) { CommandType = CommandType.StoredProcedure };

                // Input values from CustomerForm as parameters for MySql Stored Procedure 
                cmd.Parameters.AddWithValue("@p_appointmentId", appointmentModel.AppointmentId);


                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    // Update model with output data
                    appointmentModel.CustomerId = (int)dataReader["customerId"];
                    appointmentModel.UserId = (int)dataReader["userId"];
                    appointmentModel.Title = dataReader["title"].ToString();
                    appointmentModel.Description = dataReader["description"].ToString();
                    appointmentModel.Location = dataReader["location"].ToString();
                    appointmentModel.Contact = dataReader["contact"].ToString();
                    appointmentModel.Type = dataReader["type"].ToString();
                    appointmentModel.Url = dataReader["url"].ToString();
                    appointmentModel.Start = (DateTime)dataReader["start"];
                    appointmentModel.End = (DateTime)dataReader["end"];
                }
                dataReader.Close();
                Customer customerModel = new Customer { CustomerId = appointmentModel.CustomerId };
                appointmentModel.CustomerName = GlobalConfig.Connection.GetCustomer(customerModel).CustomerName;
                User userModel = new User { UserId = appointmentModel.UserId};
                appointmentModel.UserName = GlobalConfig.Connection.GetUser(userModel).Username;
            }
            return appointmentModel;
        }

        public Appointment ModifyAppointment(Appointment appointmentModel, User userModel)
        {
            using (MySqlConnection connection = OpenConnection())
            {
                // Create command line container for MySql Stored Procedure
                MySqlCommand cmd = new MySqlCommand("spAppointment_Modify", connection) { CommandType = CommandType.StoredProcedure };

                // Input values from CustomerForm as parameters for MySql Stored Procedure 
                cmd.Parameters.AddWithValue("@p_appointmentId", appointmentModel.AppointmentId);
                cmd.Parameters.AddWithValue("@p_customerId", appointmentModel.CustomerId);
                cmd.Parameters.AddWithValue("@p_userId", appointmentModel.UserId);
                cmd.Parameters.AddWithValue("@p_type", appointmentModel.Type);
                cmd.Parameters.AddWithValue("@p_start", appointmentModel.Start.ToUniversalTime());
                cmd.Parameters.AddWithValue("@p_end", appointmentModel.End.ToUniversalTime());
                cmd.Parameters.AddWithValue("@p_currentUser", userModel.Username);

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }


            }

            return appointmentModel;

        }

        public Appointment DropAppointment(Appointment appointmentModel)
        {
            using (MySqlConnection connection = OpenConnection())
            {
                // Create command line container for MySql Stored Procedure
                MySqlCommand cmd = new MySqlCommand("spAppointment_Drop", connection) { CommandType = CommandType.StoredProcedure };

                // Input values from AppointmentForm as parameters for MySql Stored Procedure 
                cmd.Parameters.AddWithValue("@p_appointmentId", appointmentModel.AppointmentId);

                cmd.ExecuteNonQuery();
            }
            return appointmentModel;
        }

        public List<Appointment> GetAppointments(int userId)
        {
            List<Appointment> output = new List<Appointment>();
            using (MySqlConnection connection = OpenConnection())
            {
                string query = $"SELECT * FROM appointment WHERE userId = {userId}";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    Customer customerModel = new Customer { CustomerId = (int)dataReader["customerId"] };
                    User userModel = new User { UserId = (int)dataReader["userId"] };
                    Appointment model = new Appointment
                    {
                        AppointmentId = (int)dataReader["appointmentId"],
                        CustomerId = (int)dataReader["customerId"],
                        UserId = (int)dataReader["userId"],
                        Title = dataReader["title"].ToString(),
                        Description = dataReader["description"].ToString(),
                        Location = dataReader["location"].ToString(),
                        Contact = dataReader["contact"].ToString(),
                        Type = dataReader["type"].ToString(),
                        Url = dataReader["url"].ToString(),
                        Start = (DateTime)dataReader["start"],
                        End = (DateTime)dataReader["end"],
                        CustomerName = GlobalConfig.Connection.GetCustomer(customerModel).CustomerName,
                        UserName = GlobalConfig.Connection.GetUser(userModel).Username
                    };
                    output.Add(model);
                }
                dataReader.Close();
            }
            return output;
        }

        public List<Appointment> GetAllAppointments()
        {

            List<Appointment> output = new List<Appointment>();
            using (MySqlConnection connection = OpenConnection())
            {
                string query = $"SELECT * FROM appointment";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    Customer customerModel = new Customer { CustomerId = (int)dataReader["customerId"] };
                    User userModel = new User { UserId = (int)dataReader["userId"] };
                    Appointment model = new Appointment
                    {
                        AppointmentId = (int)dataReader["appointmentId"],
                        CustomerId = (int)dataReader["customerId"],
                        UserId = (int)dataReader["userId"],
                        Title = dataReader["title"].ToString(),
                        Description = dataReader["description"].ToString(),
                        Location = dataReader["location"].ToString(),
                        Contact = dataReader["contact"].ToString(),
                        Type = dataReader["type"].ToString(),
                        Url = dataReader["url"].ToString(),
                        Start = (DateTime)dataReader["start"],
                        End = (DateTime)dataReader["end"],
                        CustomerName = GlobalConfig.Connection.GetCustomer(customerModel).CustomerName,
                        UserName = GlobalConfig.Connection.GetUser(userModel).Username
                    };
                    output.Add(model);
                }
                dataReader.Close();
            }
            return output;
        }

        public List<Appointment> GetCustomerAppts(int customerId)
        {
            List<Appointment> output = new List<Appointment>();
            using (MySqlConnection connection = OpenConnection())
            {
                string query = $"SELECT * FROM appointment WHERE customerId = {customerId}";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    Customer customerModel = new Customer { CustomerId = (int)dataReader["customerId"] };
                    User userModel = new User { UserId = (int)dataReader["userId"] };
                    Appointment appointmentModel = new Appointment
                    {
                        AppointmentId = (int)dataReader["appointmentId"],
                        CustomerId = (int)dataReader["customerId"],
                        UserId = (int)dataReader["userId"],
                        Title = dataReader["title"].ToString(),
                        Description = dataReader["description"].ToString(),
                        Location = dataReader["location"].ToString(),
                        Contact = dataReader["contact"].ToString(),
                        Type = dataReader["type"].ToString(),
                        Url = dataReader["url"].ToString(),
                        Start = (DateTime)dataReader["start"],
                        End = (DateTime)dataReader["end"],
                        CustomerName = GlobalConfig.Connection.GetCustomer(customerModel).CustomerName,
                        UserName = GlobalConfig.Connection.GetUser(userModel).Username
                    };
                    output.Add(appointmentModel);
                }
                dataReader.Close();
            }
            return output;
        }



        public bool TimeSlotAvail(DateTime startTime, DateTime endTime, int userId)
        {
            DateTime openTime = DateTime.Today.AddHours(8);
            DateTime closedTime = DateTime.Today.AddHours(17);

            GetAppointments(userId);

            // Verify appointment timeframe is inside business hours
            if (startTime.TimeOfDay < openTime.TimeOfDay
                || startTime.TimeOfDay > closedTime.TimeOfDay
                || endTime.TimeOfDay < openTime.TimeOfDay
                || endTime.TimeOfDay > closedTime.TimeOfDay)
            {
                MessageBox.Show("Appointment outside of normal business hours.", "Alert");
                return false;
            }

            // TODO -- LAMBDA EXPRESSIONS to find occurance of conflict with other appointments

            var startConflict = GetAppointments(userId).FindAll(s => s.Start.ToLocalTime() <= startTime && startTime <= s.End.ToLocalTime());
            var endConflict = GetAppointments(userId).FindAll(e => e.Start.ToLocalTime() <= endTime && endTime <= e.End.ToLocalTime());
            if (startConflict.Count > 0  || endConflict.Count > 0)
            {
                MessageBox.Show("Appointment conflicts with another scheduled appointment");
                return false;
            }
            return true;
        }




        private MySqlConnection OpenConnection()
        {
            MySqlConnection connection = new MySqlConnection(GlobalConfig.ConnectionString("MySqlKey"));
            try
            {
                connection.Open();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                Environment.Exit(-1);
            }

            return connection;
        }

        public User Authenticate(User userModel)
        {
            using (MySqlConnection connection = OpenConnection())
            {
                // Create command line container for MySql Stored Procedure
                MySqlCommand cmd = new MySqlCommand("spUser_Authenticate", connection) { CommandType = CommandType.StoredProcedure };

                // Input values from CustomerForm as parameters for MySql Stored Procedure 
                cmd.Parameters.AddWithValue("@p_username", userModel.Username);
                cmd.Parameters.AddWithValue("@p_password", userModel.Password);

                MySqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        if ((bool)dataReader["active"])
                        {
                            userModel.UserId = (int)dataReader["userId"];
                            userModel.Active = (bool)dataReader["active"] ? 1 : 0;
                            LogTxtFileConnector.trackLogin(userModel.UserId);
                            return (userModel);
                        }
                        else
                        {
                            MessageBox.Show("Account inavtive.", "Login Error!");
                            break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect username/password combination.", "Login Error!");
                    return (userModel);
                }
                dataReader.Close();
            }
            return (userModel);
        }


        public List<User> GetUsers()
        {
            List<User> output = new List<User>();

            using (MySqlConnection connection = OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM user", connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    User model = new User
                    {
                        UserId = (int)dataReader["userId"],
                        Username = dataReader["userName"].ToString()
                    };
                    output.Add(model);
                }
                dataReader.Close();
            }
            return output;
        }

        public User GetUser(User userModel)
        {
            using (MySqlConnection connection = OpenConnection())
            {
                // Create command line container for MySql Stored Procedure
                MySqlCommand cmd = new MySqlCommand("spUser_Get", connection) { CommandType = CommandType.StoredProcedure };

                // Input values from CustomerForm as parameters for MySql Stored Procedure 
                cmd.Parameters.AddWithValue("@p_userId", userModel.UserId);

                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    // Update model with output data
                    userModel.Username = dataReader["userName"].ToString();
                }
                dataReader.Close();
            }


            return userModel;
        }


    }
}
