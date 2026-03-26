using System;
using System.Configuration;

static class AppConfig
{
    static void Main(string[] args)
    {
        string connectionString = ConfigurationManager.AppSettings["connectionString"];
        string logLevel = ConfigurationManager.AppSettings["LogLevel"];
        string Mohamed = ConfigurationManager.AppSettings["Mohamed"];
        string DBConnectionString = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;

        Console.WriteLine("connection String: " + connectionString);
        Console.WriteLine("log level: " + logLevel);
        Console.WriteLine("Mohamed: " + Mohamed);
        Console.WriteLine("DBConnectionString: " + DBConnectionString);
    }
}
