using System;
using System.Collections.Generic;
using System.Linq;

public static class SaddlePoints
{
    public static IEnumerable<(int, int)> Calculate(int[,] matrix)
    {
        var col = new Dictionary<int, int>();
        var lin = new Dictionary<int, int>();

        var ListedLines = new Dictionary<int, int>();

        var ListedColumns = new Dictionary<int, int>();
        var k = 0;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            var iteratorCollumns = new List<int>();
            var iteratorLines = new List<int>();
            
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                // lin.Add(i, matrix[i, j]);
                // col.Add(i, matrix[k, i]);

                Console.WriteLine("Line " + i + " " + matrix[i, j]);
                // iteratorColumns.Add(matrix[k, i]);
                // iteratorLines.Add(matrix[i, j]);
            }

            // ListedLines.Add(i, iteratorLines.ToArray());
            // ListedColumns.Add(i, iteratorLines.ToArray());
            k++;
        }

        // var minValuesinLine = new Dictionary<int, int[]>();

        // var minValuesColumn = new Dictionary<int, int[]>();






        col.ToList().ForEach(x =>
        {
            Console.WriteLine("column: {0} Line: {1}", x.Key, x.Value);
        });

        // lin.ToList().ForEach(x =>
        // {
        //     var arr = x.Value;
        //     string line = "";
        //     for (int i = 0; i < arr.Length; i++)
        //     {
        //         line += arr[i] + " ";
        //     }
        //     Console.WriteLine("line: {0}", line);
        // });

        // Console.WriteLine("Length0 is: {0}", matrix.GetLength(0));//length lines
        // Console.WriteLine("Length1 is: {0}", matrix.GetLength(1));//length collumns

        return null;
    }
}
