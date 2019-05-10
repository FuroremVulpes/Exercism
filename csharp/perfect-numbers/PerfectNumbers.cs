using System;
using System.Linq;

public enum Classification
{
    Perfect,
    Abundant,
    Deficient
}

public static class PerfectNumbers
{
    public static Classification Classify(int number)
    {
        int res = number.ToString().Select(x => (int)x).Aggregate((a, b) => a + b);
        Console.WriteLine(res);
        return Classification.Perfect;
    }
}

internal class Test
{
    private static void Main()
    {
        Console.WriteLine(PerfectNumbers.Classify(6));
    }
}
