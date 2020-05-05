using System;
using System.Linq;

public static class PigLatin
{
    public static string Translate(string word)
    {
        string[] eachWord = word.Split(" ");
        string[] ruleOne = { "a", "e", "i", "o", "u", "xr", "yt" };
        string[] ruleOneExc = { "xr", "yt" };
        string[] ruleTwo = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "n", "p", "q", "r", "s", "t", "v", "w", "x", "y", "z" };
        string[] ruleTwoExc = { "ch", "qu", "th", "rh" };
        string[] ruleThree = { "squ", "thr", "sch" };
        string[] ruleFour = { "y" };
        string result = "";
        string separator = "";
        if(eachWord.Count() > 1)
        {
            separator = " ";
        }

        foreach (var wordIt in eachWord)
        {
            var firstChar = wordIt.Substring(0, 1);
            var secondChar = wordIt.Substring(1, 1);
            var twoFirstChar = wordIt.Substring(0, 2);
            var threeFirstChar = "";
            if (wordIt.Length > 2)
            {
                threeFirstChar = wordIt.Substring(0, 3);
            }
            if (ruleThree.Any(threeFirstChar.Contains))
            {
                result += wordIt.Remove(0, 3) + threeFirstChar + "ay" + separator;
            }
            else if (ruleTwoExc.Any(twoFirstChar.Contains))
            {
                result += wordIt.Remove(0, 2) + twoFirstChar + "ay"+ separator;
            }
            else if (ruleOneExc.Any(twoFirstChar.Contains))
            {
                result += wordIt + "ay"+ separator;
            }
            else if (ruleOne.Any(firstChar.Contains))
            {
                result += wordIt + "ay"+ separator;
            }
            else if (ruleTwo.Any(firstChar.Contains))
            {
                result += wordIt.Remove(0, 1) + firstChar + "ay" + separator;
            }
            
            else
                result = "";

        }
        return result.TrimEnd(' ');

    }
}