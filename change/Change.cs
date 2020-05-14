using System;
using System.Collections.Generic;
using System.Linq;

public static class Change
{
    public static int[] FindFewestCoins(int[] coins, int target)
    {

        //validate exceptions
            if (target < 0)
        {
            throw new ArgumentException();
        }
        if (target > 0 && target < coins.Min())
        {
            throw new ArgumentException();
        }

        List<int[]> coinsInList = new List<int[]>();
        var ListBase = coins;
        var it = (coins.Length - 1);

        //create a list of arrays
        while (it >= 0)
        {
            coinsInList.Add(ListBase);
            Array.Resize(ref ListBase, it);
            it--;
        }
        //compare inside the lists
        List<int[]> posChangeComb = new List<int[]>();
        var lengthOfArrays = new List<int>();

        foreach (var list in coinsInList)
        {
            List<int> curChangeComb = new List<int>();
            var len = list.Length;
            var itLen = len - 1;
            var whatIsLeft = target;

            // Console.WriteLine($"whatIsLeft = {whatIsLeft}");
            // Console.WriteLine($"list[itLen] = {list[itLen]}");
            // Console.WriteLine($"whatIsLeft - list[itLen] = {whatIsLeft - list[itLen]}");
            while (whatIsLeft > 0)
            {
                // Console.WriteLine($"whatIsLeft = {whatIsLeft}");
                // Console.WriteLine($"list[itLen] = {list[itLen]}");
                if (whatIsLeft - list[itLen] >= 0)
                {
                    curChangeComb.Add(list[itLen]);
                    whatIsLeft -= list[itLen];
                }
                else
                {
                    itLen--;
                }
            }
            Console.WriteLine("---");
            posChangeComb.Add(curChangeComb.ToArray());

        }
        var ordered = posChangeComb.OrderBy(e => e.Count());

        return ordered.First().OrderBy(f => f).ToArray();

    }
}

