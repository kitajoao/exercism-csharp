using System;
using System.Collections.Generic;
using System.Linq;


public static class PalindromeProducts
{

    private static List<Tuple<int, int, int>> CheckPalindrome(List<Tuple<int, int, int>> palindromeList, bool highest = true)
    {
        
        var orderedProduct = highest? palindromeList.OrderByDescending(p => p.Item3) : palindromeList.OrderBy(p => p.Item3);
        
        var allPalindromeNumb = new List<Tuple<int, int, int>>();
        foreach (var memb in orderedProduct)
        {
            int reminder, sum = 0;
            int numb = memb.Item3;

            while (numb > 0)
            {
                reminder = numb % 10;
                sum = (sum * 10) + reminder;
                numb = numb / 10;
            }
            if (memb.Item3 == sum || ((memb.Item1 < 10 && memb.Item2 < 10 && memb.Item3 < 10) && (memb.Item1 * memb.Item2 == memb.Item3)))
            {
                allPalindromeNumb.Add(new Tuple< int, int, int>( memb.Item1, memb.Item2, memb.Item3));
            }
        }
        return allPalindromeNumb;
    }
    public static (int, IEnumerable<(int, int)>) Largest(int minFactor, int maxFactor)
    {
        if(maxFactor - minFactor <= 1)
        {
            throw new ArgumentException();
        }
        
        List<Tuple<int, int, int>> possibleProducts = new List<Tuple<int, int, int>>();

        //create all possible products combination
        for (int i = maxFactor; i >= minFactor; i--)
        {
            int j;
            for (j = i; j >= minFactor; j--)
            {
                possibleProducts.Add(new Tuple< int, int, int>(i, j, i * j));
            }
        }

        //find all palindrome numbers
        var allPalindromeNumb = CheckPalindrome(possibleProducts, true);

        //find the highest palindrome
        var highestPalindromeNumb = allPalindromeNumb.Select(p => p.Item3).First();
        var result = new List<(int, int)>();

        foreach (var item in allPalindromeNumb)
        {
            if (item.Item3 == highestPalindromeNumb)
            {
                result.Add((item.Item2, item.Item1));
            }
        }

        return (highestPalindromeNumb, result);
    }

    public static (int, IEnumerable<(int, int)>) Smallest(int minFactor, int maxFactor)
    {
        if(maxFactor - minFactor <= 1)
        {
            throw new ArgumentException();
        }
       List<Tuple<int, int, int>> possibleProducts = new List<Tuple<int, int, int>>();

        //create all possible products combination
        for (int i = maxFactor; i >= minFactor; i--)
        {
            int j;
            for (j = i; j >= minFactor; j--)
            {
                possibleProducts.Add(new Tuple< int, int, int>(i, j, i * j));
            }
        }

        //find all palindrome numbers
        var allPalindromeNumb = CheckPalindrome(possibleProducts, false);

        // find lowest palindrome
        var smallestPalindromeNumb = allPalindromeNumb.Select(p => p.Item3).First();
        var result = new List<(int, int)>();

        foreach (var item in allPalindromeNumb)
        {
            if (item.Item3 == smallestPalindromeNumb)
            {
                result.Add((item.Item2, item.Item1));
            }
        }

        return (smallestPalindromeNumb, result);
    }
}

