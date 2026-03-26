using System;
using System.Diagnostics;
using System.Text;

internal static class StringBuilderPractice
{
    static void ConcatenateWithNormalString(int numOfIteration)
    {
        string str = string.Empty;

        for (int i = 0; i < numOfIteration; i++)
        {
            str += 'a';
        }
    }

    static void ConcatenateWithBuilderString(int numOfIteration)
    {
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < numOfIteration; i++)
        {
            sb.Append('a');
        }
    }

    static void Main(string[] args)
    {
        int numOfIteration = 209500;

        Stopwatch builderStringStopWatch = new Stopwatch();
        builderStringStopWatch.Start();
        ConcatenateWithBuilderString(numOfIteration);
        builderStringStopWatch.Stop();
        Console.WriteLine($"Builder string take: {builderStringStopWatch.ElapsedMilliseconds}ms");

        Stopwatch normalStrStopWatch = new Stopwatch();
        normalStrStopWatch.Start();
        ConcatenateWithNormalString(numOfIteration);
        normalStrStopWatch.Stop();
        Console.WriteLine($"Normal string take: {normalStrStopWatch.ElapsedMilliseconds}ms");
    }
}

