using ApplicationLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ApplicationLibrary.DataAccess
{
    public interface IDataConnection
    {
        User Authenticate(User userModel);

        Customer CreateCustomer(Customer customerModel, User userModel);
        Customer GetCustomer(Customer customerModel);
        Customer ModifyCustomer(Customer customerModel, User userModel);
        Customer DropCustomer(Customer customerModel);
        List<Customer> GetCustomerNames();
        List<Appointment> GetCustomerAppts(int customerId);
        Appointment CreateAppointment(Appointment appointmentModel, User userModel);
        Appointment GetAppointment(Appointment appointmentModel);
        List<Appointment> GetAppointments(int userId);
        List<Appointment> GetAllAppointments();
        Appointment ModifyAppointment(Appointment appointmentModel, User userModel);
        Appointment DropAppointment(Appointment model);
        List<User> GetUsers();
        User GetUser(User userModel);
        bool TimeSlotAvail(DateTime startTime, DateTime endTime, int userId);

    }
}
