using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public static class CryptoSquare
{
    public static string NormalizedPlaintext(string plaintext)
    {
        StringBuilder normalizedPlainText = new StringBuilder();

        string itStg = plaintext.ToLower();


        foreach (var c in itStg)
        {
            if ((c >= '0' && c <= '9') ||
            (c >= 'a' && c <= 'z'))
            {
                normalizedPlainText.Append(c);
            }
        }
        return normalizedPlainText.ToString();

    }
    /*primeira parte ok */
    public static Tuple<int, int> NumbRowsAndCols(string plaintext)
    {
        var normPlainText = NormalizedPlaintext(plaintext);
        int c = (int)Math.Sqrt(normPlainText.Length);
        int r = (int)Math.Sqrt(normPlainText.Length);

        while (r * c < normPlainText.Length)
        {
            c += 1;
            if (r * c < normPlainText.Length)
            {
                r += 1;
            }
        }

        return new Tuple<int, int>(c, r);
    }
    /*segunda parte estah ok */
    public static IEnumerable<string> PlaintextSegments(string plaintext)
    {
        var arraysOfStg = new List<string>();

        int col = NumbRowsAndCols(plaintext).Item1;
        int row = NumbRowsAndCols(plaintext).Item2;
        var normPlainText = NormalizedPlaintext(plaintext);

        StringBuilder itStg = new StringBuilder();

        for (int i = 0; i < normPlainText.Length; i++)
        {
            itStg.Append(normPlainText[i]);

            if (itStg.Length == col)
            {
                arraysOfStg.Add(itStg.ToString());

                itStg = itStg.Clear();
            }
            if ((i == normPlainText.Length - 1 && (row * col) > normPlainText.Length))
            {

                itStg = itStg.Insert(itStg.Length, " ", ((row * col) - normPlainText.Length));

                arraysOfStg.Add(itStg.ToString());
                break;
            }
        }

        return arraysOfStg;
    }
    public static string Encoded(string plaintext)
    {
        var encodedStg = new StringBuilder();
        var itArry = PlaintextSegments(plaintext).ToArray();

        int col2 = NumbRowsAndCols(plaintext).Item1;
        int row2 = NumbRowsAndCols(plaintext).Item2;


        for (int i = 0; i < col2; i++)
        {
            for (int j = 0; j < row2; j++)
            {
                encodedStg.Append(itArry[j][i]);
            }
        }
        return encodedStg.ToString();
    }
    public static string Ciphertext(string plaintext)
    {
        var encodedStgForResult = Encoded(plaintext);

        var arrayItResult = new List<string>();
        var result = string.Empty;

        int col3 = NumbRowsAndCols(plaintext).Item1;

        int row3 = NumbRowsAndCols(plaintext).Item2;

        StringBuilder itStg = new StringBuilder();

        for (int i = 0; i < encodedStgForResult.Length; i++)
        {
            itStg.Append(encodedStgForResult[i]);

            if (itStg.Length == row3)
            {
                arrayItResult.Add(itStg.ToString());

                itStg = itStg.Clear();
            }
        }
        return string.Join(" ", arrayItResult);
    }
}