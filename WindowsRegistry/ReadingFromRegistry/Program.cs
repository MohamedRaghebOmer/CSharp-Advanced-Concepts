using System;
using Microsoft.Win32;

static class ReadingFromRegistry
{
    static void Main(string[] args)
    {
        string keyPath = @"HKEY_CURRENT_USER\SOFTWARE\YourSoftware";
        string valueName = @"YourValueName";

        try
        {
            string valueData = Registry.GetValue(keyPath, valueName, null) as string;

            if (valueData != null)
            {
                Console.WriteLine($"Success. Value data is [{valueData}].");
            }
            else
            {
                Console.WriteLine("Failed to read.");
            }

        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex);
        }
    }
}
