using System;
using System.Collections.Generic;
using System.Linq;

public static class SecretHandshake
{
    public static string[] Commands(int commandValue)
    {
        var stringBinary = Convert.ToString(commandValue, 2).ToCharArray().Reverse().ToArray();

        List<string> answer = new List<string>();

        string[] typesAnswer = new string[] { "wink", "double blink", "close your eyes", "jump" };

        if (stringBinary.Length >= 4 && stringBinary[3] == '1')
        {
            answer.Add(typesAnswer[3]);
        }
        if (stringBinary.Length >= 3 && stringBinary[2] == '1')
        {
            answer.Add(typesAnswer[2]);
        }
        if (stringBinary.Length >= 2 && stringBinary[1] == '1')
        {
            answer.Add(typesAnswer[1]);
        }

        if (stringBinary.Length >= 1 && stringBinary[0] == '1')
        {
            answer.Add(typesAnswer[0]);
        }
        if (stringBinary.Length <= 4)
        {
            answer.Reverse();
        }
        return answer.ToArray();
    }
}