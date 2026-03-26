using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static Action ParameterlessProcedureDelegate = ParameterlessProcedure;

    static Action<bool> OneParameterDelegate = OneParameterProcedure;

    static Action<bool, int> MultipleParameterDelegate = MultipleParameterProcedure;

    static void ParameterlessProcedure()
    {
        Console.WriteLine("ParameterlessProcedure is called");
    }

    static void OneParameterProcedure(bool parameter)
    {
        Console.WriteLine("OneParameterProcedure is called given parameter = " + parameter);
    }

    static void MultipleParameterProcedure(bool parameter1, int parameter2)
    {
        Console.WriteLine($"MultipleParameterProcedure is called given parameter1 = {parameter1}, parameter2 = {parameter2}");
    }

    static void Main(string[] args)
    {
        ParameterlessProcedureDelegate?.Invoke();
        OneParameterDelegate?.Invoke(true);
        MultipleParameterDelegate?.Invoke(true, 5);
    }
}
