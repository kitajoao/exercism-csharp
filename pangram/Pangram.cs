using System;
using System.Linq;

public static class Pangram
{
    public static bool IsPangram(string input)
    {
        string alphabet ="abcdefghijklmnopqrstuvwxyz";
        
        string concatStg = "";

        input = input.ToLower();

        if(input.Length < alphabet.Length)
        {
            return false;
        }
        
        for(int i = 0; i < input.Length; i++)
        {
            Console.WriteLine("input: {0}, {1}", i, input[i]);

            if(alphabet.IndexOf(input[i]) != -1 && concatStg.IndexOf(input[i]) == -1)
            {
                concatStg += input[i];
            }
        }
        if(concatStg.Length == alphabet.Length)
        {
            return true;
        }
        return false;
    }
}
