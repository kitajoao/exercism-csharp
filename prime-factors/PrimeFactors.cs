using System;
using System.Collections.Generic;
using System.Linq;
public static class PrimeFactors
{
    public static long[] Factors(long number)
    {
        var listResult = new List<long>();

        long it = number;

        long divisor = 2;

        while (it > 1)
        {
            if (it % divisor != 0)
            {
                divisor = divisor + 1;
            }

            if (it % divisor == 0)
            {
                it = it /divisor;

                listResult.Add(divisor);
            }
        }

        return listResult.ToArray();
    }
}