using System;

public static class ReverseString
{
    public static string Reverse(string input)
    {
        char [] RevStg = input.ToCharArray();

        Array.Reverse(RevStg);

        return new string(RevStg);
    }
}