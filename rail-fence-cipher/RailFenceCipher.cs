using System;
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
    throw new NotImplementedException("You need to implement this function.");
}
}

