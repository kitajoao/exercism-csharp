using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

public static class Sieve
{
    public static int[] Primes(int limit)
    {
        if (limit < 2)
        {
            throw new ArgumentOutOfRangeException();
        }

        var numbersUpToLimit = new HashSet<int>();
        var primes = new HashSet<int>(limit);

        for (var l = 2; l <= limit; l++)
        {
            if (numbersUpToLimit.Contains(l) == false
                && primes.Contains(l) == false)
            {
                primes.Add(l);
            }

            var c = l;
            do
            {
                numbersUpToLimit.Add(c);
                c = c + l;
            } while(c <= limit);
        }

        return primes.ToArray();

        // int[] numbersUpToLimit = new int[limit - 1];

        // bool[] isPrime = new bool[limit - 1];

        // int[] primeNumbers = new int[isPrime.Length];

        // if (limit >= 2)
        // {
        //     for (int i = 0; i < limit - 1; i++)
        //     {
        //         numbersUpToLimit[i] = i + 2;

        //         isPrime[i] = true;
        //     }

        //     Console.WriteLine("Numbers up to limit are: {0}", numbersUpToLimit);

        //     for (int i = 2; i <= numbersUpToLimit.Length / 2; i++)
        //     {
        //         if (isPrime[i])
        //         {
        //             for (int j = i * 2; j <= numbersUpToLimit.Length / 2; j += i)
        //                 isPrime[j] = false;
        //         }
        //     }

        //     for (int i = 0; i < isPrime.Length; i++)
        //     {
        //         if (isPrime[i] == true)
        //         {
        //             primeNumbers[i] = numbersUpToLimit[i];
        //         }
        //     }

        //     return primeNumbers;
        // }

        // return null;
    }

}



























//         for (int i = 0; i < limit; i++)
//         {
//             numbersUpToLimit[i] = i + 2;
//         }


//         int[] multipleNumbers = new int[numbersUpToLimit.Length -1];

//         for (int i = 0; i < numbersUpToLimit.Length; i++)
//         {
//             for (int j = 0; j < numbersUpToLimit.Length; j++)
//             {
//                 multipleNumbers[i] = (i + 2) * (j + 1);
//             }
//         }

//         int[] primeNumbers = new int[numbersUpToLimit.Length - 1];

//         for (int i = 0; i < multipleNumbers.Length; i++)
//         {
//             for (int j = 0; j < numbersUpToLimit.Length; j++)
//             {
//                 if (multipleNumbers[i] != (j + 2))
//                 {
//                     primeNumbers[i] = (j + 2);
//                 }
//             }
//         }

//         return primeNumbers;
//     }

//     return null;
// }