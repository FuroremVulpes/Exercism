using System;

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
        if (number <= 0)
            throw new ArgumentOutOfRangeException();
        
        var aliquotSum = CountAliquotSum(number);

        if (aliquotSum == number && aliquotSum != 1)
            return Classification.Perfect;
        else if (aliquotSum > number)
            return Classification.Abundant;

        return Classification.Deficient;
    }

    private static int CountAliquotSum(int number)
    {
        var AliquotSum = 1; // 1 is also a divisor

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                if (number / i == i)
                    AliquotSum += i;
                else
                    AliquotSum += (number / i + i);
            }
        }
        return AliquotSum;
    }
}