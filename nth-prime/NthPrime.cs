using System;
using System.Collections.Generic;
using System.Linq;

public static class NthPrime
{
    public static int Prime(int nth)
    {
        List<int> primePositions = new List<int>();
        List<int> primeNumb = new List<int>();
        int actualPrimePos = 0;
        int actualPrimeNumb = 1;
        int numb = 2;

        int primeCount = 0;

        if(nth == 0)
        {
            throw new ArgumentOutOfRangeException();
        }
    
        while (actualPrimePos != nth)
        {
            var it = 1;
            for (int i = 2; i <= numb; i++)
            {
                if (numb % i == 0)
                {
                    if (numb == i && it == 1)
                    {
                        primeCount++;
                        primeNumb.Add(i);
                        primePositions.Add(primeCount);
                        break;
                    }
                    else
                    {
                        it++;
                    }

                    continue;                
                }
            }
            actualPrimeNumb = primeNumb.Last();
            actualPrimePos = primePositions.Last();
            numb++;
        }
        return actualPrimeNumb;
    }




    
}