using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

public static class FlattenArray
{
    public static IEnumerable Flatten(IEnumerable input)
    {
        var finalArray = new List<int>();

        foreach (var item in input)
        {
            if(item == null)
            {
                continue;
            }
            if (item.GetType() == typeof(int))
            {
                finalArray.Add(Convert.ToInt32(item));
            }
            else if (item.GetType() == typeof(object[]))
            {
                IteratorObject(finalArray, item as object[]);
            }
        }
        return finalArray.ToArray();
    }

    public static List<int> IteratorObject(List<int> arr, object[] data)
    {
        foreach(var item in data)
        {
            if(item == null)
            {
                continue;
            }
            if(item.GetType() == typeof(int))
            {
                arr.Add(Convert.ToInt32(item));
            }
            else if (item.GetType() == typeof(object[]))
            {
                IteratorObject(arr, item as object[]);
            }
        }
        return arr;
    }
}