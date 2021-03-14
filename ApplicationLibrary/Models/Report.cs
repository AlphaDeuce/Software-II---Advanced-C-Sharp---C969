using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLibrary.Models
{
    public class Report
    {
        public string Consultant { get; set; }
        public string CustName { get; set; }
        public string ApptType { get; set; }
        public string ApptStart { get; set; }
        public string ApptEnd { get; set; }

        public Report(string userName, string custName, string apptType, string apptStart, string apptEnd)
        {
            Consultant = userName;
            CustName = custName;
            ApptType = apptType;
            ApptStart = apptStart;
            ApptEnd = apptEnd;
        }
    }
}
