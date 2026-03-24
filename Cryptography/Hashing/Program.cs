using System;
using System.Security.Cryptography;
using System.Text;

internal static class Hashing
{
    static string ComputeHash(string password)
    {
        using (SHA256 s = SHA256.Create())
        {
            byte[] hashBytes = s.ComputeHash(Encoding.UTF8.GetBytes(password));
            return BitConverter.ToString(hashBytes).Replace("-", "");
        }
    }

    static void Main(string[] args)
    {
        bool again = true;

        while (again)
        {
            Console.Write("Enter password to hash: ");
            string password = Console.ReadLine();
            Console.WriteLine($"Password after hashing is {ComputeHash(password)}");

            Console.Write("\nDo you want to has another password [Y|N]? ");
            again = string.Equals(Console.ReadLine(), "y", StringComparison.OrdinalIgnoreCase);
        }
    }
}
