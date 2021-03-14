using ApplicationLibrary.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ApplicationLibrary.DataAccess
{
    public class LogTxtFileConnector
    {
        static public void trackLogin(int userID)
        {
            string filePath = "logfile.txt";
            string log = $"UserID : '{userID}' successful login attempt at {DateTime.Now} UTC\r\n";
            File.AppendAllText(filePath, log);
        }
    }
}
