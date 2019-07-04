using System;
using System.Collections.Generic;

public static class Proverb
{
    public static string[] Recite(string[] subjects)
    {
        var result = new List<string>();
        
        string[] lastphrase = {"And all for the want of a "};
        
        string[] stphrase = {"For want of a ", " the ", " was lost."};
        

        if (subjects.Length == 0)
        {
            return result.ToArray();
        }

        if(subjects.Length == 1)
        {
            string x = lastphrase[0] + subjects[0] + "."; 
            result.Add(x);
        }
        if(subjects.Length > 1)
        {
            string y = stphrase[0] + subjects[0] + stphrase[1] + subjects[1] + stphrase[2];

            Console.WriteLine("y is equal to: {0}", y);
            
            result.Add(y);
            
            for(int i = 1; i < subjects.Length - 1; i++)
            {
                result.Add(stphrase[0] + subjects[i] + stphrase[1] + subjects[i + 1] + stphrase[2]);
            }
            
            result.Add(lastphrase[0] + subjects[0] + ".");
            
        }

        return result.ToArray();
    }
}