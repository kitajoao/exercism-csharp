using System;
using System.Collections.Generic;

public static class NucleotideCount
{
    public static IDictionary<char, int> Count(string sequence)
    {

        Console.WriteLine("aisfha");

        var Count = new Dictionary<char, int>()
        {
            ['A'] = 0,
            ['C'] = 0,
            ['G'] = 0,
            ['T'] = 0
        };

        if (sequence.Length == 0)
        {
            return Count;
        }
        
        for (int i = 0; i < sequence.Length; i++)
        {
            if (sequence[i] == 'A')
            {
                Count['A']++;
            }
            else if (sequence[i] == 'C')
            {
                Count['C']++;
            }
            else if (sequence[i] == 'T')
            {
                Count['T']++;
            }
            else if (sequence[i] == 'G')
            {
                Count['G']++;
            }
            else
            {
                throw new ArgumentException(); 
            }
                
        }

        return Count;
        

    }
}