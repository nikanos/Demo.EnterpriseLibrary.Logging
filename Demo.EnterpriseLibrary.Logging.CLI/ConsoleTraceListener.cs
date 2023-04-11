using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Logging;
using Microsoft.Practices.EnterpriseLibrary.Logging.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Logging.TraceListeners;
using System;
using System.Diagnostics;

namespace Demo.EnterpriseLibrary.Logging.CLI
{
    [ConfigurationElementType(typeof(CustomTraceListenerData))]
    public class ConsoleTraceListener : CustomTraceListener
    {
        public override void Write(string message)
        {
            Console.Write(message);
        }

        public override void WriteLine(string message)
        {
            Console.WriteLine(message);
        }

        public override void TraceData(TraceEventCache eventCache, string source, TraceEventType eventType, int id, object data)
        {
            var entry = data as LogEntry;

            if (entry != null)
            {
                if (Formatter != null)
                    WriteLine(Formatter.Format(entry));
                else
                    WriteLine(entry.Message);
            }
        }
    }
}
