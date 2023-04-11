
using Microsoft.Practices.EnterpriseLibrary.Logging;
using System.Diagnostics;

namespace Demo.EnterpriseLibrary.Logging.CLI
{
    class Logger
    {
        public LogWriter LogWriter { get; set; }
        public Logger()
        {
            LogWriterFactory logWriterFactory = new LogWriterFactory();
            LogWriter = logWriterFactory.Create();
        }

        public void LogInformation(string logMessage)
        {
            WriteLogHelper(logMessage, TraceEventType.Information);
        }

        public void LogWarning(string logMessage)
        {
            WriteLogHelper(logMessage, TraceEventType.Warning);
        }

        public void LogError(string logMessage)
        {
            WriteLogHelper(logMessage, TraceEventType.Error);
        }

        public void LogVerbose(string logMessage)
        {
            WriteLogHelper(logMessage, TraceEventType.Verbose);
        }

        public void LogDebug(string logMessage)
        {
            if (LogWriter.IsLoggingEnabled())
            {
                var logEntry = new LogEntry()
                {
                    Message = logMessage,
                    Severity = TraceEventType.Verbose
                };
                logEntry.Categories.Add("Debug");
                LogWriter.Write(logEntry);
            }
        }

        private void WriteLogHelper(string logMessage, TraceEventType traceEventType)
        {
            if (LogWriter.IsLoggingEnabled())
            {
                var logEntry = new LogEntry()
                {
                    Message = logMessage,
                    Severity = traceEventType
                };
                LogWriter.Write(logEntry);
            }
        }
    }
}
