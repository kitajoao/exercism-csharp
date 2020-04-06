using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

public static class RunLengthEncoding
{
    public static string Encode(string input)
    {
        if (input.Length == 0)
            return input;

        var ret = "";
        var countChar = 1;
        char lastChar = default(char);

        foreach (var chr in input)
        {
            if (lastChar == chr)
            {
                countChar++;
            }
            else if (lastChar != default(char) && lastChar != chr)
            {
                if (countChar > 1)
                    ret += countChar.ToString() + lastChar;
                else
                    ret += lastChar;

                countChar = 1;
            }

            lastChar = chr;
        }

        if (countChar > 1)
            ret += countChar.ToString() + lastChar;
        else
            ret += lastChar;

        return ret;

    }

    public static string Decode(string input)
    {
        var dgt = default(string);
        var ret = "";

        foreach (var chr in input)
        {
            if (char.IsDigit(chr))
            {
                dgt += chr;
            }
            else
            {
                var dgtCount = 1;
                int.TryParse(dgt, out dgtCount);
                dgt = default(string);
                ret += chr.ToString().PadRight(dgtCount, chr);
            }
        }
        return ret;
    }
}

