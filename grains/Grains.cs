using System;
using System.Collections.Generic;
using System.Linq;


public static class Grains
{
    public static ulong Square(int n)
    {
        if (n > 0 && n <= 64)
        {
            int potEl = n - 1;

            ulong QtyGrains;

            QtyGrains = (ulong)Math.Pow(2, potEl);

            // Console.WriteLine("Quantity of grains: {0}", QtyGrains);

            return QtyGrains;
        }
        else
        {
            throw new ArgumentOutOfRangeException();
        }
    }

    public static ulong Total()
    {
        ulong totalGrains = 0;
        
        for(int i = 0; i < 64 ;i++ )
        {
            totalGrains += (ulong)Math.Pow(2, i);
        }    
        
        return totalGrains;
    }
}