using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using StorageAssist.Enums;
using StorageAssist.Models;
using StorageAssist.Services.Commands;

namespace StorageAssist.Services
{
    
    public class LoggingService : ISystemLogging
    {
        public List<LogMessage> logMessages;
        public async void Log(LogMessage logMessage)
        {
            await AddLog(logMessage);
        }

        public void LogCreate()
        {
            throw new NotImplementedException();
        }

        public void SetPath(string path)
        {
            throw new NotImplementedException();
        }
        //-----------------------------------------//
        public async Task<bool> AddLog(LogMessage message)
        {
            logMessages.Add(message);
            if (logMessages.Count >= 10)
            {
                await CreateLogAsync();
            }
            return await Task.FromResult(true);
        }
        public async Task<bool> CreateLogAsync()
        {
            List<LogMessage> _logMessages = logMessages;
            logMessages.Clear();
            LogCommand logCommand = new LogCommand();
            logCommand.Log(_logMessages);
            return await Task.FromResult(true);
        }
    }
}
