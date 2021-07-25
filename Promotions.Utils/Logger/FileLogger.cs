using System;
using System.Threading.Tasks;

namespace Logger
{
    public class FileLogger : ILogger
    {
        public Task Log(string message, LogLevel type, Exception ex = null)
        {
            //Mohan - To Do - Implement the file logging logic
            return Task.Delay(10);
        }

        public Task Log(Exception ex)
        {
            //Mohan - To Do - Implement the file logging logic
            return Task.Delay(10);
        }
    }
}
