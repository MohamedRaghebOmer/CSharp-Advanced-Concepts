using System;
using Microsoft.Win32;

static class WritingToRegistry
{
    static void Main(string[] args)
    {
        string keyPath = @"HKEY_CURRENT_USER\SOFTWARE\YourSoftware";
        string valueName = @"YourValueName";
        string valueData = @"YourValueData";

        try
        {
            Registry.SetValue(keyPath, valueName, valueData, RegistryValueKind.String);

            Console.WriteLine("Success");
        }
        catch(Exception ex)
        {
            Console.WriteLine("Error: " + ex);
        }
    }
}
