using System;
using System.Collections.Generic;

public static class PythagoreanTriplet
{
    public static IEnumerable<(int a, int b, int c)> TripletsWithSum(int sum)
    {
        var answer = new List<(int, int, int)>();


        for (int ai = 1; ai < sum / 3; ai++)
        {
            for (int bi = ai; bi < sum / 2; bi++)
            {
                int ci = sum - ai - bi;

                if ((ai * ai) + (bi * bi) == (ci * ci))
                {
                    answer.Add((ai, bi, ci));
                }
            }
        }
        return answer.ToArray();
    }
}