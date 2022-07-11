using System;
using System.Collections.Generic;
using System.IO;
using StorageAssist.Models;

namespace StorageAssist.Services.Commands
{
    public class LogCommand
    {
        
        private readonly string path = "../StorageAssistLog/log.txt";

        public void Log(List<LogMessage> logMessages)
        {
            using (StreamWriter sw = File.AppendText(path))
                foreach (LogMessage logMessage in logMessages)
                {
                    string logtext = $"[{logMessage.Severity} {logMessage.Date}| {logMessage.Type} || {logMessage.Message}] \r\n";
                    Console.WriteLine(logtext);
                    LogToFile(logtext, sw);
                }
        }
        public void LogToFile(string log, TextWriter textWriter)
        {
            try
            {
                textWriter.WriteLine(log);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

        }
    }
}
