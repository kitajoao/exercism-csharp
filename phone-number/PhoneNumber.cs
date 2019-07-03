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
        Console.WriteLine("The size of the string is: {0}", cleanedNumb.Length);
        Console.WriteLine("The position 0 in the array is: {0}", cleanedNumb[0]);
        Console.WriteLine("The array is: {0}", cleanedNumb);

        if(cleanedNumb.Length == 10)
        {
            if(cleanedNumb[0] != 0 || cleanedNumb[3] != 0)
            {
            return cleanedNumb;
            }
        }
    
        throw new ArgumentException();        
    }
}