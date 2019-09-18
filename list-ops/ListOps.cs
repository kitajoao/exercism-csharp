using System;
using System.Collections.Generic;
using System.Linq;

public static class ListOps
{
    public static int Length<T>(List<T> input)
    {
        return input.Count;
    }

    public static List<T> Reverse<T>(List<T> input)
    {
        input.Reverse();

        return input;
    }

    public static List<TOut> Map<TIn, TOut>(List<TIn> input, Func<TIn, TOut> map)
    {

        var mapAnswer = input.Select(map);

        return mapAnswer.ToList();
    }

    public static List<T> Filter<T>(List<T> input, Func<T, bool> predicate)
    {

        var filteredAnswer = input.Where(x => predicate(x) == true);

        return filteredAnswer.ToList();
    }

    public static TOut Foldl<TIn, TOut>(List<TIn> input, TOut start, Func<TOut, TIn, TOut> func)
    {
        var resultFoldl = start;

        foreach (var item in input)
        {
            resultFoldl = func(resultFoldl, item);
        }

        return resultFoldl;
    }

    public static TOut Foldr<TIn, TOut>(List<TIn> input, TOut start, Func<TIn, TOut, TOut> func)
    {
        var resultFoldr = start;

        foreach (var item in Reverse(input))
        {
            resultFoldr = func(item, resultFoldr);
        }

        return resultFoldr;
    }

    public static List<T> Concat<T>(List<List<T>> input)
    {
        var concatLists = new List<T>();
        foreach (var item in input)
        {
            concatLists.AddRange(item);

        }
        return concatLists;
    }

    public static List<T> Append<T>(List<T> left, List<T> right)
    {
        left.AddRange(right);
        return left;
    }
}