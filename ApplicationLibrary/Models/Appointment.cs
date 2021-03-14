using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationLibrary.Models
{
    public class Appointment
    {
        public int AppointmentId { get; set; }
        public int CustomerId { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public string Contact { get; set; }
        public string Type { get; set; }
        public string Url { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string CustomerName { get; set; }
        public string UserName { get; set; }

        public string ApptSelectDisplay
        {
            get { return Start.ToShortDateString().ToString() + $" ({CustomerName})"; }
        }

    }
}
