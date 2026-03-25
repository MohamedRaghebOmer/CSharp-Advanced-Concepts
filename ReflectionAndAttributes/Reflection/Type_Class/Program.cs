using System;

internal static class Program
{
    static void Main(string[] args)
    {
        Type myType = typeof(long);

        Console.WriteLine("---------------------Type Information---------------------");
        Console.WriteLine($"Name: {myType.Name}");
        Console.WriteLine($"Full Name: {myType.FullName}");
        Console.WriteLine($"Is Class: {myType.IsClass}");
    }
}
