using System;
using System.Collections.Generic;
using System.Linq;

public static class LargestSeriesProduct
{
    public static long GetLargestProduct(string digits, int span)
    {
        int numPos = (digits.Length) - span + 1;
        char[] digitsInChar = digits.ToCharArray();
        int[] arrayWithStringInNumb = new int[numPos];

        int numbit = 1;
        int result;
        int numPosi = 0;

        if (digits.Length < span || span < 0)
        {
            throw new ArgumentException();
        }
        var exp = digitsInChar.Select(x => char.IsLetter(x)).Where(x => x == true).ToList();

        if (exp.Count > 0)
        {
            throw new ArgumentException();
        }
        if (span == 0)
        {
            return 1;
        }

        for (int i = 0; i < numPos; i++)
        {
            for (int j = 0; j < span; j++)
            {
                numbit *= Convert.ToInt32(digitsInChar[i + j].ToString());
            }
            if ((i == ((digits.Length) - span + 1)))
            {
                break;
            }
            arrayWithStringInNumb[numPosi] = numbit;
            Console.WriteLine(arrayWithStringInNumb[numPosi]);
            numbit = 1;
            numPosi++;
        }
        result = arrayWithStringInNumb.Max();

        return result;
    }
}