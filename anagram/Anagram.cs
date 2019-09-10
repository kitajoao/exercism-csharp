using System;
using System.Linq;
using System.Collections.Generic;

public class Anagram
{
    public static string convertedBaseWord;
    public static string baseWord2;
    public Anagram(string baseWord)
    {
        char[] conv = baseWord.ToLower().ToCharArray();
        Array.Sort(conv);
        convertedBaseWord = new string(conv);
        baseWord2 = baseWord;
    }
    public string[] FindAnagrams(string[] potentialMatches)
    {

        string[] sortedStrings = new string[potentialMatches.Length];

        bool[] trueConditions = new bool[potentialMatches.Length];

        var result = new List<string>();

        for (int i = 0; i < potentialMatches.Length; i++)
        {
            char[] convtwo = potentialMatches[i].ToLower().ToCharArray();
            Array.Sort(convtwo);
            sortedStrings[i] = new string(convtwo);

            if (sortedStrings[i].ToLower().Equals(convertedBaseWord.ToLower()))
            {
                trueConditions[i] = true;
            }
            else
                trueConditions[i] = false;
        }
        for (int i = 0; i < trueConditions.Length; i++)
        {
            if (trueConditions[i] == true && potentialMatches[i].ToLower() != baseWord2.ToLower())
            {
                result.Add(potentialMatches[i]);
            }
        }
        return result.ToArray();
    }
}