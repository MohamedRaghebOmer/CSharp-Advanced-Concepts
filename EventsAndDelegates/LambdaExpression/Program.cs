using System;

internal static class LambdaExpression
{
    public static Func<int, int> Square = x => x * x;

    public static Action ParameterlessAction = () => Console.WriteLine("This is a parameterless action.");

    public delegate int Operation(int x, int y);

    public static Action<int> ActionWithIntParameter = x => Console.WriteLine("Action with int parameter.");

    public static Action<string, int> ActionWithMultipleParameter = (x, y) => Console.WriteLine("Action with parameter.");

    public static void ExecuteOperation(int x, int y, Func<int, int, int> Operation) => Console.WriteLine(Operation(x, y));

    public static void ExecuteOperation(int x, int y, Operation op) => Console.WriteLine(op(x, y));

    static void Main(string[] args)
    {
        Console.WriteLine(Square(4));
        ParameterlessAction();
        ActionWithIntParameter(3);
        ActionWithMultipleParameter("Hello", 1);

        Operation Add = (x, y) => x + y;
        Operation Sub = (x, y) => x - y;
        Func<int, int, int> Mul = (x, y) => x * y;
        Func<int, int, int> Div = (x, y) => x / y;

        ExecuteOperation(4, 4, Add);
        ExecuteOperation(4, 4, Sub);
        ExecuteOperation(4, 4, Mul);
        ExecuteOperation(4, 4, Div);
    }
}
