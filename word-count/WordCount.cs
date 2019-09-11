using System;
using System.Collections.Generic;

public static class WordCount
{
    public static IDictionary<string, int> CountWords(string phrase)
    {
        string cleanedPhrase = "";
        bool asp = false;

        foreach (var item in phrase.ToLower().Replace(",", " ").Replace("\n", " "))
        {
            if(asp == true && char.IsLetterOrDigit(cleanedPhrase[cleanedPhrase.Length-1]) && char.IsLetterOrDigit(item))
            {
               cleanedPhrase += '\'';
            }
            
            if(char.IsLetterOrDigit(item) ==  true || item == ' ')
            {
                cleanedPhrase += item;
            }
            asp = (item == '\'') ? true : false;
        }
        var phraseWithoutSpace = cleanedPhrase.Split(new char[]{' '});
        
        var listClear = new List<string>();

        foreach(var item in phraseWithoutSpace)
        {
            if(!string.IsNullOrWhiteSpace(item))
                listClear.Add(item);
        }
        var repeatedWords = new Dictionary<string, int>();

        for (int i = 0; i < listClear.Count; i++)
        {
            if(repeatedWords.ContainsKey(listClear[i]))
            {
                int stg = repeatedWords[listClear[i]];
                repeatedWords[listClear[i]] = stg + 1;
            }
            else
            {
                repeatedWords.Add(listClear[i], 1);
            }
        }
        return repeatedWords;
    }
}