using System.Collections.Generic;

public static class RomanNumeralExtension
{
    private static Dictionary<int, string>  romanNumbers = new Dictionary<int, string>()
    {
        { 1000, "M" }, { 900, "CM" }, { 500, "D" }, { 400, "CD" }, { 100, "C" },
        { 90, "XC" }, { 50, "L" }, { 40, "XL" }, { 10, "X" },
        { 9, "IX" }, { 5, "V" }, { 4, "IV" }, { 1, "I" } 
    };

    public static string ToRoman(this int value)
    {
        var romanNumber = string.Empty;

        do
        {
            foreach (var item in romanNumbers)
            {
                if (value / item.Key > 0)
                {
                    romanNumber += item.Value;
                    value = value - item.Key;
                    break;
                }
            }
        } while (value > 0);

        return romanNumber;
    }
}
