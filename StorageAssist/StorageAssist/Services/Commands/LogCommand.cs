using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Reflection;
using StorageAssist.Models;

namespace StorageAssist.Services.Commands
{
    public class LogCommand
    {
        private readonly string path;

        public void Log(List<LogMessage> logMessages)
        {
            foreach(LogMessage logMessage in logMessages)
            {
                string logtext = $"[{logMessage.Severity} {logMessage.Date}| {logMessage.Type} || {logMessage.Message}]";
                Console.WriteLine(logtext);
            }
        }
    }
}
