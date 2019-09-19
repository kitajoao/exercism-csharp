using System;
using System.Collections.Generic;
using System.Linq;


public static class SaddlePoints
{
    public static IEnumerable<(int, int)> Calculate(int[,] matrix)
    {

        int numbCols = matrix.GetLength(1);
        int numbLines = matrix.GetLength(0);

        int[,] maxValsLines = new int[numbLines, numbCols];
        int[,] maxValsCols = new int[numbLines, numbCols];

        //iterator for lines
        for (int i = 0; i < numbLines; i++)
        {
            int maxValLine = 0;
            for (int j = 0; j < numbCols; j++)
            {
                if (matrix[i, j] >= maxValLine)
                {
                    maxValLine = matrix[i, j];
                }
            }
            for (int j = 0; j < numbCols; j++)
            {
                if (matrix[i, j] == maxValLine)
                {
                    maxValsLines[i, j] = maxValLine;
                    Console.WriteLine(maxValLine);
                }
                else
                    maxValsLines[i, j] = 0;
            }
        }

        //iterator for columns
        for (int i = 0; i < numbCols; i++)
        {
            int maxValCol = matrix[0, i];
            
            for (int j = 0; j < numbLines; j++)
            {
                if (matrix[j, i] <= maxValCol)
                {
                    maxValCol = matrix[j, i];
                }
            }
            for (int j = 0; j < numbLines; j++)
            {
                if (matrix[j, i] == maxValCol)
                {
                    maxValsCols[j, i] = maxValCol;
                    Console.WriteLine(maxValCol);
                }
                else
                    maxValsCols[j, i] = 0;
            }
        }
        var result = new List<(int, int)>();
        for (int i = 0; i < numbLines; i++)
        {
            for (int j = 0; j < numbCols; j++)
            {
                if (maxValsLines[i, j] == maxValsCols[i, j]
                && maxValsLines[i, j] > 0 
                && maxValsCols[i, j] > 0)
                {
                    result.Add((i + 1, j + 1));
                }
            }
        }
        return result.ToArray();
    }
}
