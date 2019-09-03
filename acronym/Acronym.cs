using System;
using System.Linq;

public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        string result = "";

        phrase = phrase.ToUpper();
        
        phrase = phrase.Replace('-', ' ').Replace("   "," ").Replace('_', ' ').Replace("  "," ");

        string[] words = phrase.Split(' ');

        foreach (var word in words)
        {
            result += word[0];
        }
        return result;
    }
}