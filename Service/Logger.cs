using System;
using System.Diagnostics;

namespace DOIPR.Service
{
    public static class Logger
    {

        /// <summary>
        /// The application name that will appear in the event log.
        /// </summary>
        const string source = "DOIPR";

        /// <summary>
        /// The event log type.
        /// </summary>
        const string log = "Application";

        /// <summary>
        /// Writes a new message to the system event log.
        /// </summary>
        /// <param name="eventType"></param>
        /// <param name="message"></param>
        public static void PushMessage(string eventType, string message)
        {
            if (!EventLog.SourceExists(source))
                EventLog.CreateEventSource(source, log);

            EventLog.WriteEntry(source, message, EventLogEntryType.Information);
            //EventLog.WriteEntry(source, message, EventLogEntryType.Warning, 234);
        }
    }
}
