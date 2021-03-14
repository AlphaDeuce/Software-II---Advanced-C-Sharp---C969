using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationLibrary
{
    public enum DatabaseType
    {
        MySql,
        LogTextFile
    }

    public enum RecordType
    {
        User,
        Customer,
        Appointment,
        Month
    }

    public enum RecordAction
    {
        Modify,
        Drop,
        Report
    }

    public enum ReportType
    {
        Month,
        User,
        Customer
    }
}
