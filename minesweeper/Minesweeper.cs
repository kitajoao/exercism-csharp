using System;
using System.Collections.Generic;
using System.Linq;

public static class Minesweeper
{
    public static string[] Annotate(string[] input)
    {
        string[] returnMine = input;
        
        string[] charMatrix = input.;

        int numbLines = input.Length;
        int numbCols = input[0].Length;
        
        var stringMineField = new string[numbLines, numbCols];
        var intMineField = new int[numbLines, numbCols];

        // for (int i = 0; i < numbLines; i++)
        // {
        //     charMatrix.Add(input[i].Split("").ToArray());
        // }

        Console.WriteLine(numbLines);
        Console.WriteLine(numbCols);

        return returnMine;
    }
}
