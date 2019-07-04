using System;

public static class ScrabbleScore
{
    public static int Score(string input)
    {
        
        input = input.ToUpper();

        int score = 0;

        string onepoint = "AEIOULNRST";

        string twopoints = "DG";

        string threepoints = "BCMP";
        
        string fourpoints = "FHVWY";

        string fivepoints = "K";

        string eightpoints = "JX";

        string tenpoints = "QZ";

        for(int i = 0; i < input.Length; i++)
        {
            if(onepoint.IndexOf(input[i]) != -1)
            {
                score = score + 1;
            }
            if(twopoints.IndexOf(input[i]) != -1)
            {
                score = score + 2;
            }
            if(threepoints.IndexOf(input[i]) != -1)
            {
                score = score + 3;
            }
            if(fourpoints.IndexOf(input[i]) != -1)
            {
                score = score + 4;
            }
            if(fivepoints.IndexOf(input[i]) != -1)
            {
                score = score + 5;
            }
            if(eightpoints.IndexOf(input[i]) != -1)
            {
                score = score + 8;
            }
            if(tenpoints.IndexOf(input[i]) != -1)
            {
                score = score + 10;
            }
        }
    
        return score;
    }   
}