using System;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        if (word == "")
        {
            return true;
        }

        string alphabet = "abcdefghijklmnopqrstuvwxyz";

        string concatStg = "";

        word = word.ToLower();

        for (int m = 0; m < word.Length; m++)
        {
            if (alphabet.IndexOf(word[m]) != -1)
            {
                concatStg += word[m];
            }
        }

        Console.WriteLine("string concatenada eh igual a: {0}", concatStg);


        int p = -1, i, j;
        for (i = 0; i < concatStg.Length; i++)
        {
            for (j = i + 1; j < concatStg.Length; j++)
            {
                if (concatStg[i] == concatStg[j])
                {
                    p = i;
                }
            }
        }
        if (p != -1)
            return false;
        else
            return true;
    }
}
