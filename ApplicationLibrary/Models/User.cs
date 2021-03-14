using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationLibrary.Models
{
    public class User
    {
        public List<Appointment> UserAppointments { get; set; } = new List<Appointment>();
        
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Active { get; set; }

    }
}
