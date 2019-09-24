using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

public class Matrix
{
    int[,] matrix;
    int _row;
    int _col;
    public Matrix(string input)
    {
        string[] inputInStgArray = input.Split("\n".ToCharArray());

        int numbRows = inputInStgArray.Length;
        int numbCols = inputInStgArray[0].Replace(" ", "").Length;
        
        matrix = new int[numbRows, numbCols];

        for (int i = 0; i < inputInStgArray.Length; i++)
        {
            var aux = inputInStgArray[i].Split(" ");

            for (int j = 0; j < aux.Length; j++)
            {
                var aux2 = Convert.ToInt32(aux[j]);

                matrix[i, j] = aux2;
            }
        }
    }
    public int Rows
    {
        get
        {
            return matrix.GetLength(0);
        }
        set
        {
            _row = value;
        }
    }
    public int Cols
    {
        get
        {
            return matrix.GetLength(1);
        }
        set
        {
            _col = value;
        }
    }
    public int[] Row(int row)
    {
        int[] resultRows = new int[Cols];

        for (int i = 0; i < Cols; i++)
        {
            resultRows[i] = matrix[(row - 1), i];
        }

        return resultRows;
    }
    public int[] Column(int col)
    {
        int[] resultCols = new int[Rows];

        for (int i = 0; i < Rows; i++)
        {
            resultCols[i] = matrix[i, (col - 1)];
        }
        return resultCols;
    }
}