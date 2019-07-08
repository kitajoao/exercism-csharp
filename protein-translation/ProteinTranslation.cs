using System;

public static class ProteinTranslation
{
    public static string[] Proteins(string strand)
    {
        string[] condonstypes = { "AUG", "UUU", "UUC", "UUA", "UUG", "UCU", "UCC", "UCA", "UCG", "UAU", "UAC", "UGU", "UGC", "UGG", "UAA", "UAG", "UGA" };

        string[] proteinstypes = { "Methionine", "Phenylalanine", "Phenylalanine", "Leucine", "Leucine", "Serine", "Serine", "Serine", "Serine", "Tyrosine", "Tyrosine", "Cysteine", "Cysteine", "Tryptophan", "STOP", "STOP", "STOP" };

        int countcondon = 0;

        if (strand.Length % 3 != 0)
        {
            return null;
        }

        if (strand.Length % 3 == 0)
        {
            countcondon = strand.Length / 3;
        }

        string[] condonstrands = new string[countcondon];

        int[] poscondon = new int[countcondon];


        Console.WriteLine("Length condonstrands: {0}", condonstrands.Length);

        for (int i = 0; i < countcondon; i++)
        {
            condonstrands[i] = strand.Substring((i * 3), 3);
        }

        for (int j = 0; j < condonstrands.Length; j++)
        {
            for (int k = 0; k < condonstypes.Length; k++)
            {
                if (condonstrands[j] == condonstypes[k])
                {
                    poscondon[j] = k;
                }
            }
        }

        var pos = 0;

        for (int i = 0; i < poscondon.Length; i++)
        {
            if (proteinstypes[poscondon[i]] != "STOP")
            {
                pos++;
            }
            else
                break;
        }


        Console.WriteLine("pos é igual a : {0}", pos);
        if(pos == 0)
         {
            return Array.Empty<string>();
        }
        
        string[] proteinanswer = new string[pos];

        for(int i = 0; i < pos; i++)
        {
            proteinanswer[i] = proteinstypes[poscondon[i]];
        }

        return proteinanswer;

        //return null;
    }
}