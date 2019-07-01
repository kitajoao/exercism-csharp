using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

 
public static class AccumulateExtensions
{
    public static IEnumerable<U> Accumulate<T, U>(this IEnumerable<T> collection, Func<T, U> func)
    {
        return collection.Select(x => func(x));   
    }

}