using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationLibrary.Models
{
    public class Customer
    {
        public List<Appointment> CustomerAppointments { get; set; } = new List<Appointment>();

        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public int AddressId { get; set; }
        public int Active { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public int CityId { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Phone { get; set; }
        public int CountryId { get; set; }
        public string Country { get; set; }

        public Customer()
        {

        }

    }
}
