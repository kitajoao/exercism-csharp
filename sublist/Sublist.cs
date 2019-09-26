using System;
using System.Collections.Generic;
using System.Linq;
public enum SublistType
{
    Equal,
    Unequal,
    Superlist,
    Sublist
}

public static class Sublist
{
    public static SublistType Classify<T>(List<T> list1, List<T> list2)
        where T : IComparable
    {
        var fisrtExceptSecond = list1.Except(list2).Any();
        var SecondExceptFirst = list2.Except(list1).Any();

        var sizeList1 = list1.Count;
        var sizeList2 = list2.Count;

        var checkList1 = list1.OfType<int>().Zip(list1.OfType<int>().Skip(1), (a, b) => (a + 1) == b).All(x => x);
        var checkList2 = list2.OfType<int>().Zip(list2.OfType<int>().Skip(1), (a, b) => (a + 1) == b).All(x => x);

        if(!checkList1 && checkList2 || checkList1 && !checkList2)
        {
            return SublistType.Unequal;
        } 
        
        if (list1.SequenceEqual(list2))
        {
            return SublistType.Equal;
        }
        else if (!fisrtExceptSecond && SecondExceptFirst)
        {
            return SublistType.Sublist;
        }
        else if (!SecondExceptFirst && fisrtExceptSecond)
        {
            return SublistType.Superlist;
        }
        return SublistType.Unequal;
    }
}