using System;
using System.Collections.Generic;
using System.Linq;
public static class ParallelLetterFrequency
{
    public static Dictionary<char, int> Calculate(IEnumerable<string> texts)
    {
        var qtyOfChars = new Dictionary<char, int>();

        var list = texts.ToList().Select(x=> x.ToLower().Select(y => y))
                        .SelectMany(x => x.Where(y => Char.IsLetter(y)));
        
        foreach (var item in list)
        {
            if (qtyOfChars.ContainsKey(item))
            {
                qtyOfChars[item]++;
            }
            else
            {
                qtyOfChars.Add(item, 1);
            }

        }

        return qtyOfChars;
    }
}