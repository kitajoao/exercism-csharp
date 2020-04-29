using System;
using System.Collections.Generic;
using System.Linq;

public static class Transpose
{
    public static string String(string input)
    {
        var rows = input.Split('\n');
        var maxLengthOfLine = rows.Max(x => x.Length);
        var transposed = new string[maxLengthOfLine];

        for (int i = 0; i < rows.Length; i++)
        {
            for (int j = 0; j < rows[i].Length; j++)
            {
                transposed[j] += rows[i][j];
            }
            
            var remainderRowsMaximumLength = rows.Skip(i).Max(x => x.Length);
            for (var k = rows[i].Length; k < remainderRowsMaximumLength; k++)
                transposed[k] += " ";
        }


        Console.WriteLine(string.Join("\n", transposed).TrimEnd());
        return string.Join("\n", transposed).TrimEnd();
    }
}

