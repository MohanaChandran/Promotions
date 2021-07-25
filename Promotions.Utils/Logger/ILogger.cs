using System;
using System.Threading.Tasks;

namespace Logger
{
    public interface ILogger
    {
        //Mohan - Implemet a Init method so that the logging configs can be passed from the main project
        Task Log(string message, LogLevel type, Exception ex = null);
        Task Log(Exception ex);
    }

    public enum LogLevel
    {
        Error,
        Info
    }
}
