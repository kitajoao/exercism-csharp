using System;
using System.Text;
using System.Collections.Generic;
public static class Series
{
    public static string[] Slices(string numbers, int sliceLength)
    {
        int sizeString = numbers.Length;

        int qtyString = sizeString - sliceLength + 1;

        string[] setStrings = new string[qtyString];

        if (sliceLength > sizeString || sliceLength <= 0)
        {
            throw new System.ArgumentException();
        }

        for (int i = 0; i < qtyString; i++)
        {
            setStrings[i] = numbers.Substring(i, sliceLength);
        }

        return setStrings;
    }
}
// String value = "This is a string."; => this is a string that will be selected;
// int startIndex = 5; => in what position the string will start;
// int length = 2; => the size of the string;
// String substring = value.Substring(startIndex, length); => doing the string;
// Console.WriteLine(substring); => printing the string;
