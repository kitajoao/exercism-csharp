using System;

public class SpiralMatrix
{
    public static int[,] GetMatrix(int size)
    {
        int[,] SpiralMatrix = new int[size, size];
        int printValue = 1;
        int c1 = 0, c2 = size - 1;
        while (printValue <= size * size)
        {
            //Right Direction Move  
            for (int i = c1; i <= c2; i++)
                SpiralMatrix[c1, i] = printValue++;
            //Down Direction Move  
            for (int j = c1 + 1; j <= c2; j++)
                SpiralMatrix[j, c2] = printValue++;
            //Left Direction Move  
            for (int i = c2 - 1; i >= c1; i--)
                SpiralMatrix[c2, i] = printValue++;
            //Up Direction Move  
            for (int j = c2 - 1; j >= c1 + 1; j--)
                SpiralMatrix[j, c1] = printValue++;
            c1++;
            c2--;
        }

        return SpiralMatrix;
    }
}
