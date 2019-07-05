using System;

public static class ProteinTranslation
{
    public static string[] Proteins(string strand)
    {
        string[] condonstypes = { "AUG", "UUU", "UUC", "UUA", "UUG", "UCU", "UCC", "UCA", "UCG", "UAU", "UAC", "UGU", "UGC", "UGG", "UAA", "UAG", "UGA" };

        string[] proteinstypes = { "Methionine", "Phenylanine", "Phenylanine", "Leucine", "Leucine", "Serine", "Serine", "Serine", "Serine", "Tyrosine", "Tyrosine", "Cystenine", "Cystenine", "Tryptophan", "STOP", "STOP", "STOP" };

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

        int [] poscondon = new int[countcondon];
        
        string[] proteinanswer = new string[countcondon];
        
        Console.WriteLine("Length condonstrands: {0}", condonstrands.Length);

        for (int i = 0; i < countcondon; i++)
        {

            condonstrands[i] = strand.Substring((i * 3), 3);

            
        }

        for (int j = 0; j < condonstrands.Length; j++)
        {
            for(int k = 0; k < condonstypes.Length; k++)
            {
                if(condonstrands[j] == condonstypes[k])
                {
                    poscondon[j] = k;
                }
            }
        }

        for (int i = 0; i < poscondon.Length; i++)
        {
            proteinanswer[i] = proteinstypes[poscondon[i]];

            Console.WriteLine(proteinanswer[i]);
        }
        return condonstrands;
    }
}