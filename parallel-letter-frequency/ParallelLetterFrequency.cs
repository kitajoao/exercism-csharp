using System;
using System.Collections.Generic;
using System.Linq;
public static class ParallelLetterFrequency
{
    public static Dictionary<char, int> Calculate(IEnumerable<string> texts)
    {
        return texts
            .SelectMany(x => x.ToLowerInvariant().Where(y => Char.IsLetter(y)))
            .GroupBy(e => e)
            .Select(group => new { Char = group.Key, Count = group.Count()})
            .ToDictionary(e => e.Char, e => e.Count);
    }
}