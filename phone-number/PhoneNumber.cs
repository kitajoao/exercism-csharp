using System;

public class PhoneNumber
{
    public static string Clean(string phoneNumber)
    {
        string possibleNumb = "234567890";
        
        string cleanedNumb = "";

        for(int i = 0; i < phoneNumber.Length; i++)
        {
            if(possibleNumb.IndexOf(phoneNumber[i]) != -1)
            {
                cleanedNumb += phoneNumber[i];
            }
        }   
        if(cleanedNumb[0] == 1 || cleanedNumb[0] == 0)
        {
            throw new ArgumentException();
        }
        if(cleanedNumb.Length != 10)
        {
            throw new ArgumentException();
        }
        if(cleanedNumb.Length == 10)
        {
            return cleanedNumb;
        }
    
        return null;
    }
}