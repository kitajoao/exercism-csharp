using System;
using System.Collections.Generic; 

public static class Raindrops
{
    public static string Convert(int number)
    {
        
        std :: string divNumbers;

        string [] typeAnswer = new string{""};
        
        for(int i = 1; i <= number; i++)
        {
            if(number % i == 0)
            {
                divNumbers.Add(i);
            }
        }
        
        for(int j = 0; j<number; j++)
        {
            switch (divNumbers[j])
            {
                case 3:
                    typeAnswer.Add("Pling");
                    break;
                
                case 5:
                    typeAnswer.Add("Plang");
                    break;

                case 7:
                    typeAnswer.Add("Plong");
                    break;

            }

        }

        return typeAnswer;
        
// throw new NotImplementedException("You need to implement this function.");
    }
}