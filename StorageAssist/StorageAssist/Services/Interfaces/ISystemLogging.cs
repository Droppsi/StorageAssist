using System;
using System.Collections.Generic;
using System.Text;
using StorageAssist.Enums;
using StorageAssist.Models;

namespace StorageAssist.Services.Interfaces
{
    internal interface ISystemLogging
    {
        void Log(LogMessage logMessage);
        void SetPath(string path);
        void LogCreate();
    }
}
