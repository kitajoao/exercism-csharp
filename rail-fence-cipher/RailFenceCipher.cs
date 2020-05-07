using System;
using System.Collections.Generic;
using System.Linq;

public class RailFenceCipher
{

    private readonly int _rails;
    public RailFenceCipher(int rails)
    {
        _rails = rails;
    }

    public string Encode(string input)
    {
        var eachRow = new string[_rails];
        var posRow = 0;
        var dir = 1;
        var count = 0;

        for (int i = 0; i < input.Length; i++)
        {
            eachRow[posRow] += input[i];
            posRow += dir;
            count++;
            if (count == _rails - 1)
            {
                dir *= -1;
                count = 0;
            }
        }
        return eachRow.Aggregate("", (x, y) => x + y);
    }
    public string Decode(string input)
    {
        var eachRowEnc = SplitEncodedString(input, _rails).ToArray();

        Console.WriteLine(eachRowEnc[0]);




        return "";
    }


    static IEnumerable<string> SplitEncodedString(string input, int rails)
    {
        return Enumerable.Range(0, input.Length / rails)
            .Select(i => input.Substring(i * rails, rails));
    }

}

