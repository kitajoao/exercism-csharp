using System;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        if (word == "")
        {
            return true;
        }

        word[1].
        int count = 0;
        for (int i = 0; i < word.Length; i++)
        {
            for (int j = 0; j < word.Length; j++)
            {
                if (word[i] == word[j])
                {
                    count++;
                }
            }
        }
        if (count > word.Length)
        {
            return true;
        }
        return false;
    }
}
