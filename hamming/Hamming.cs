using System;
public static class Hamming
{
    public static int Distance(string firstStrand, string secondStrand)
    {
    
        if (firstStrand == null || secondStrand == null 
            || firstStrand?.Length != secondStrand?.Length)
        {
            throw new ArgumentException();
        }

        if (firstStrand.Length == 0  && secondStrand.Length == 0 
            || (firstStrand == secondStrand))
        {
            return 0;
        }

        int count = 0;
        for (var i = 0; i < secondStrand.Length; i++)
        {
            if(firstStrand[i] != secondStrand[i])
            {
                count++;
            }
        }  
        Debug.Write("oiaishskf");
        Console.Write("oiaishskf");
        Debug.WriteLine("oiaishskf");
        Console.WriteLine("oasf");
        Logger
            return count;            
    }
}