using System;
using System.Linq;

public static class Grains
{
    public static ulong Square(int n)
    {
        return n >= 1 && n <= 64 ? 1UL << (n - 1) : throw new ArgumentOutOfRangeException();
    }

    public static ulong Total()
    {
        return Enumerable.Range(1,64).Select(x => Square(x)).Aggregate((a, b) => a + b);
    }
}