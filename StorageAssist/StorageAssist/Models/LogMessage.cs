using System;
using System.Collections.Generic;
using System.Text;
using StorageAssist.Enums;

namespace StorageAssist.Models
{
    public class LogMessage
    {
        public string Message { get; set; }
        public string Type { get; set; }
        public DateTime Date { get; set; }
        public Severity Severity { get; set; }
    }
}
