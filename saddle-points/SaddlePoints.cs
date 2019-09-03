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













// if (matrix.GetLength(0) == 0)
// {
//     return Enumerable.Empty<(int, int)>();
// }

// var maxrow = 0;
// var mincolumn = 0;
// var row = new List<int>();
// var column = new List<int>();

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         if (matrix[i, j] >= maxrow)
//         {
//             maxrow = matrix[i, j];
//         }
//         if (j < matrix.GetLength(1) && matrix[j, i] <= mincolumn || mincolumn == 0)
//         {
//             mincolumn = matrix[j, i];
//         }

//     }
//     row.Add(maxrow);
//     column.Add(mincolumn);
//     maxrow = 0;
//     mincolumn = 0;
// }

// maxrow = row.Min();
// mincolumn = column.Max();
// var pos = new List<(int, int)>();
// var a = false;
// Console.WriteLine($"max row = {maxrow}, min column = {mincolumn}");
// if (maxrow == mincolumn)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         a = false;
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (matrix[i, j] == maxrow)
//             {
//                 pos.Add((i + 1, j + 1));
//                 a = true;
//             }
//         }

//     }

//     return pos.ToArray();



// return new (int, int)[] { };


// foreach(var item in posWithVal)
//     Console.WriteLine($"{item.Key.Item1}, {item.Key.Item2} Value: {item.Value}");

// var d = posWithVal.Select((x, i) => new { Index = i, Value = x })
//           .GroupBy(x => x.Index / 3)
//           .Select(x => x.Select(y => y.Value).ToList())
//           .ToList();

// foreach(var item in d)
// {
//     foreach(var sub in item)
//     {
//         Console.WriteLine($"{sub.Key.Item1}, {sub.Key.Item2} Value: {sub.Value}");
//     }
// }






// var higherValuesInLines = new Dictionary<Tuple<int, int>, int>();

// var higherValuesInColumns = new Dictionary<Tuple<int, int>, int>();

// var s  = posWithVal.OrderBy(x => x.Value).Last();

//higherValuesInLines.Add(s.Key, s.Value);



// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         var s  = posWithVal.OrderBy(x => x.Value).Last();
//         higherValuesInLines.Add(s.Key, s.Value);
//     }
// }








//     var iteratorColumns = new List<int>();
//     var iteratorLines = new List<int>();

//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         iteratorColumns.Add(matrix[k, i]);
//         iteratorLines.Add(matrix[i, j]);
//     }

//     ListedLines.Add(i, iteratorLines.ToArray());
//     ListedColumns.Add(i, iteratorLines.ToArray());
//     k++;
// }

// ListedColumns.OrderBy(ListedColumns => ListedColumns.Value);
// ListedLines.OrderBy(ListedLines => ListedLines.Value);



// var minColumns = ListedColumns.ContainsKey(k => k.Value where).Min();
// {
//     Console.WriteLine("column: {0} Line: {1}", x.Key, x.Value);
// });

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

// return null;
