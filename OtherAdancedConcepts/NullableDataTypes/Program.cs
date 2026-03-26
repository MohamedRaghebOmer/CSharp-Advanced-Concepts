using System;

internal static class NullableDataTypes
{
    static void Main(string[] args)
    {
        Nullable<int> nullableInt1 = null;
        int? nullableInt2 = null;

        if (nullableInt1.HasValue)
        {
            Console.WriteLine(nullableInt1.ToString());
        }
        else
        {
            Console.WriteLine("nullableInt1 is null");
        }

        if (nullableInt2.HasValue)
        {
            Console.WriteLine(nullableInt2.ToString());
        }
        else
        {
            Console.WriteLine("nullableInt2 is null");
        }

        int result = nullableInt2 ?? 0;
        Console.WriteLine("result = " + result);

        string stringValue = nullableInt1?.ToString();
        Console.WriteLine($"stringValue = {stringValue}");
    }
}

