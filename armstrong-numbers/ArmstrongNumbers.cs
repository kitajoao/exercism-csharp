using System;
using System.Diagnostics;

public static class ArmstrongNumbers
{
    public static bool IsArmstrongNumber(int number)
    {        
        string numbString = number.ToString();
        int ArmstrongNumb = 0;

        for (int i = 0; i < numbString.Length; i++)
        {
            ArmstrongNumb += (int)Math.Pow((int)char.GetNumericValue(numbString[i]), numbString.Length);
        }
        
        if (ArmstrongNumb == number)
        {
            return true;
        }
        
        return false;
    }
}