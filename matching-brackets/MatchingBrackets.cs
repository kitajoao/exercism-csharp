using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

public static class MatchingBrackets
{
    private static readonly char[] OpenParenthesis = { '(', '[', '{' };
    private static readonly char[] CloseParenthesis = { ')', ']', '}' };

    public static bool IsPaired(string input)
    {
        Stack<int> parenthesis = new Stack<int>();

        foreach (char chr in input)
        {
            int index;

             if ((index = Array.IndexOf(OpenParenthesis, chr)) != -1)
            {
                parenthesis.Push(index);
            }
            else if ((index = Array.IndexOf(CloseParenthesis, chr)) != -1)
            {
                if (parenthesis.Count == 0 || parenthesis.Pop() != index)
                    return false;
            }
        }
        return parenthesis.Count == 0;
    }
}
