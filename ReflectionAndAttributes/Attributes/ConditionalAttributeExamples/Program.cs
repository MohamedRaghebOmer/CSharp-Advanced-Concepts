//#define DEBUG
#define Mohamed

using System;
using System.Diagnostics;

public class MyClass
{
    [Conditional("DEBUG")]
    public void DebugMethod()
    {
        Console.WriteLine("This is debug method.");
    }

    [Conditional("Mohamed")]
    public void Mohamed()
    {
        Console.WriteLine("Mohamed is called.");
    }

    [Conditional("Ali")]
    public void Ali()
    {
        Console.WriteLine("Ali is called.");
    }

    [Obsolete("This method is marked as obsolete, and will be deprecated in the future.")]
    public void OldMethod()
    {
        Console.WriteLine("Obsolete method is called.");
    }

    public void NormalMethod()
    {
        Console.WriteLine("Normal method is called.");
    }
}

internal static class ConditionalAttributeExamples
{
    static void Main(string[] args)
    {
        MyClass cls = new MyClass();

        cls.DebugMethod();
        cls.Mohamed();
        cls.Ali();
        cls.OldMethod();
        cls.NormalMethod();
    }
}
