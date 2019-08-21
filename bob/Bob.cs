using System;
using System.Linq;
using System.Collections.Generic;
public static class Bob
{
    public static string Response(string statement)
    {
        string letters = "abcdefghijklmnopqrstuvwxyz";

        var statementClearOfSpecChars = "";

        bool validator = false;

        if (string.IsNullOrWhiteSpace(statement))
        {
            return "Fine. Be that way!";
        }
        for (var i = 0; i < statement.Length; i++)
        {
            if (char.IsLetter(statement[i]))
            {
                statementClearOfSpecChars += statement[i];
            }
        }
        for (var i = 0; i < statementClearOfSpecChars.Length; i++)
        {
            if (letters.ToUpper().IndexOf(statementClearOfSpecChars[i]) > -1)
            {
                validator = true;
            }
            else
            {
                validator = false;

                break;
            }
        }
        statement = statement.Trim();

        if (validator == true && statement.Last() == '?')
        {
            return "Calm down, I know what I'm doing!";
        }
        else if (validator == true && statement.Last() != '?')
        {
            return "Whoa, chill out!";
        }
        else if (validator == false && statement.Last() == '?')
        {
            return "Sure.";
        }
        return "Whatever.";
    }
}