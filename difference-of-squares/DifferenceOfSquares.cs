using System;
using Xunit;
using Xunit.Abstractions;
public static class DifferenceOfSquares
{
    
    public static int CalculateSquareOfSum(int max)
    {
        int SqSum = 0;

        int SqSum1 = 0;
         
        for(int i = 1; i<= max; i++)
        {
            SqSum1 += i;
            //Console.WriteLine(SqSum1);
        }
        
        SqSum = (int)Math.Pow(SqSum1, 2);

        //Console.WriteLine(SqSum);

        return SqSum;
    }

    public static int CalculateSumOfSquares(int max)
    {
        int SumSq = 0;

        // Console.WriteLine("Start for: " + SumSq);
        
        for(int j = max; j > 0; j--)
        {
            // Console.WriteLine("j: " +j);
            
            SumSq += j * j;
            
            // Console.WriteLine("SumSq: " + SumSq);
        }
        
        return SumSq;
    }

    public static int CalculateDifferenceOfSquares(int max)
    {
        
        int DifSumSq = DifferenceOfSquares.CalculateSumOfSquares(max);
    
        int DifSqSum = DifferenceOfSquares.CalculateSquareOfSum(max);

        int DifSq = DifSqSum - DifSumSq;

        // Console.WriteLine("Difference of squares: {0}", DifSq);

        return DifSq;
    }   
}