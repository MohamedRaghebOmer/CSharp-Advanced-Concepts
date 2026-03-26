using System;
using System.Diagnostics;

static class Program
{
    static void Main(string[] args)
    {
        // Specify source name for the event log
        string sourceName = "MyAppName";

        // Create the source if does not exist. 
        if (!EventLog.SourceExists(sourceName))
        {
            EventLog.CreateEventSource(sourceName, "Application");
            Console.WriteLine("Source created successfully.");
        }

        // Log an information message
        EventLog.WriteEntry(sourceName, "This is an information message.", EventLogEntryType.Information);

        // Log a warning message
        EventLog.WriteEntry(sourceName, "This is a warning message.", EventLogEntryType.Warning);

        // Log an error message
        EventLog.WriteEntry(sourceName, "This is an error message.", EventLogEntryType.Error);
    }
}