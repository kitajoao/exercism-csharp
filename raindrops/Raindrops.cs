using System;
using System.Collections.Generic;


public static class Raindrops
{
    public static string Convert(int number)
    {

        string typeAnswer = "";
    
        if(number % 3 == 0)
        {
            typeAnswer += "Pling";
        }
        
        if(number % 5 == 0)
        {
            typeAnswer += "Plang";
        }
        
        if(number % 7 == 0)
        {
            typeAnswer += "Plong";
        }
        
        if (typeAnswer == "")
        {
            return number.ToString();
        }

        return typeAnswer;
    }
}






