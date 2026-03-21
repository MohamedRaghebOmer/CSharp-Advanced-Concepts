using System;
using System.Data.SqlClient;
using System.IO;

public class Logger
{
    public delegate void LogAction(string message);
    private event LogAction _logAction;

    public Logger(LogAction logAction)
    {
        this._logAction = logAction;
    }

    public void Log(string message)
    {
        this._logAction?.Invoke(message);
    }
}

internal static class Program
{
    static void LogToScreen(string message)
    {
        Console.WriteLine(message);
    }

    static void LogToDatabase(string message)
    {
        // Write the code will log to database
    }

    static void LogToFile(string message)
    {
        string fileName = "log.txt";

        using (StreamWriter writter = new StreamWriter(fileName))
        {
            writter.Write(message);
        }
    }

    static void Main(string[] args)
    {
        Logger screenLogger = new Logger(LogToScreen);
        Logger databaseLogger = new Logger(LogToDatabase);
        Logger fileLogger = new Logger(LogToFile);

        screenLogger.Log("This message will be logged on the screen.");
        databaseLogger.Log("This message will be logged in the database.");
        fileLogger.Log("This message will be logged in file.");
    }
}
