using System;
using System.Collections.Generic;
using System.Linq;

public static class AtbashCipher
{
    public static string plainAlphabet = "abcdefghijklmnopqrstuvwxyz123456789";
    public static string cipherAlphabet = "zyxwvutsrqponmlkjihgfedcba123456789";

    public static string Encode(string plainValue)
    {
        string encodeResult = "";
        int count = 0;
        plainValue = plainValue.ToLowerInvariant().Replace(" ", "")
                               .Replace(",", "").Replace(".", "");

        Console.WriteLine(plainValue);
        for (int i = 0; i < plainValue.Length; i++)
        {
            if (encodeResult.Length == (5 * (count + 1) + count))
            {
                encodeResult += " ";
                count++;
            }
            for (int j = 0; j < plainAlphabet.Length; j++)
            {
                if (plainValue[i] == plainAlphabet[j])
                {
                    encodeResult += cipherAlphabet[j];
                }
            }
        }
        Console.WriteLine(encodeResult);
        return encodeResult;
    }
    public static string Decode(string encodedValue)
    {
        int count = 0;
        encodedValue = encodedValue.ToLowerInvariant().Replace(" ", "")
                                   .Replace(",", "").Replace(".", "");

        string decodeResult = "";

        for (int i = 0; i < encodedValue.Length; i++)
        {
            for (int j = 0; j < cipherAlphabet.Length; j++)
            {
                if (encodedValue[i] == cipherAlphabet[j])
                {
                    decodeResult += plainAlphabet[j];
                }
            }
        }
        return decodeResult;
    }
}
