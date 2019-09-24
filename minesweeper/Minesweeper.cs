using System;
using System.Collections.Generic;
using System.Linq;

public static class Minesweeper
{
    public static string[] Annotate(string[] input)
    {

        if (input == Array.Empty<string>() || input[0] == "")
        {
            return input;
        }

        int numbLines = input.Length;
        int numbCols = input[0].Length;

        var stringMineField = new string[numbLines, numbCols];
        var intMineField = new int[numbLines, numbCols];

        var result = new string[numbLines];

        for (int i = 0; i < numbLines; i++)
        {
            for (int j = 0; j < numbCols; j++)
            {
                stringMineField[i, j] = input[i].Substring(j, 1);
            }
        }
        for (int i = 0; i < numbLines; i++)
        {
            for (int j = 0; j < numbCols; j++)
            {
                int coount = 0;

                Console.WriteLine(stringMineField[i, j]);

                if (stringMineField[i, j] == " ")
                {
                    if (i - 1 >= 0 && stringMineField[i - 1, j] == "*")//uma linha para tras
                    {
                        coount++;
                    }
                    if (i - 1 >= 0 && j + 1 < numbCols && stringMineField[i - 1, j + 1] == "*")//diagonal acima direita
                    {
                        coount++;
                    }
                    if ( i - 1 >= 0 && j - 1 >= 0 && stringMineField[i - 1, j - 1] == "*")//diagonal abaixo esquerda
                    {
                        coount++;
                    }
                    if (i + 1 < numbLines && stringMineField[i + 1, j] == "*")//uma linha para frente
                    {
                        coount++;
                    }
                    if (j - 1 >= 0 && stringMineField[i, j - 1] == "*")//uma coluna para tras
                    {
                        coount++;
                    }
                    if (j + 1 < numbCols && stringMineField[i, j + 1] == "*")//uma coluna para frente
                    {
                        coount++;
                    }
                    if (i + 1 < numbLines && j + 1 < numbCols && stringMineField[i + 1, j + 1] == "*")//diagonal abaixo direita
                    {
                        coount++;
                    }
                    if ( i + 1 < numbLines && j - 1 >= 0 && stringMineField[i + 1, j - 1] == "*")//diagonal acima esquerda
                    {
                        coount++;
                    }

                    if (coount == 0)
                    {
                        result[i] += " ";
                    }
                    else
                    {
                        result[i] += coount;
                    }
                }
                else
                    result[i] += "*";
            }
        }


        return result;
    }
}


