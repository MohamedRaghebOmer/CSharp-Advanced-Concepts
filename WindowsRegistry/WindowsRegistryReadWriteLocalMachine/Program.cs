using Microsoft.Win32;
using System;

static class WindowsRegistryReadWriteLocalMachine
{
    static void Main(string[] args)
    {
        string keyPath = @"HKEY_LOCAL_MACHINE\SOFTWARE\YourSoftware";
        string valueName = @"YourValueName";
        string valueData = @"YourValueData";

        try
        {
            Registry.SetValue(keyPath, valueName, valueData, RegistryValueKind.String);

            Console.WriteLine("Success");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex);
        }
    }
}
