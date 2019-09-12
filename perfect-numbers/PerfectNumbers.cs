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
        {
            throw new ArgumentOutOfRangeException();
        }


        int[] MCD = new int[number / 2];

        for (int i = 1; i <= number / 2; i++)
        {
            if (number % i == 0)
            {
                MCD[i - 1] = i;
            }
        }

        int sumMCD = 0;

        for (int i = 0; i < MCD.Length; i++)
        {
            sumMCD = sumMCD + MCD[i];
        }

        if (sumMCD == number)
        {
            return Classification.Perfect;
        }
        else if (sumMCD > number)
        {
            return Classification.Abundant;
        }
        else
        {
            return Classification.Deficient;
        }
    }
}
