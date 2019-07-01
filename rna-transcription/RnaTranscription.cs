using System;
using System.Diagnostics;

public static class RnaTranscription
{
    public static string ToRna(string nucleotide)
    {
        string RNATranscripted = "";

        for(int i = 0; i<nucleotide.Length; i++)
        {
            
            if(nucleotide[i] == 'C')
            {
                RNATranscripted += "G";
            }
            else if(nucleotide[i] == 'G')
            {
                RNATranscripted += "C";
            }
            else if(nucleotide[i] == 'T')
            {
                RNATranscripted += "A";
            }
            else if(nucleotide[i] == 'A')
            {
                RNATranscripted += "U";
            }
            
       }
        return RNATranscripted;
    }
}