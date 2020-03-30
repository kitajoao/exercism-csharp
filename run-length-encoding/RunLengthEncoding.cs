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

        // var ret = new List<(char, int)>();
        // var pos = 0;
        // char lastChar = default(char);

        // foreach (var chr in input)
        // {
        //     if (lastChar != chr)
        //     {
        //         ret.Add((chr, 1));
        //     }
        //     else if (lastChar == chr)
        //     {
        //         var tuple = ret[ret.Count - 1];
        //         tuple.Item2 += 1;
        //         ret[ret.Count - 1] = tuple;
        //     }

        //     lastChar = chr;
        //     pos++;
        // }

        // return ret
        //     .Select(t => { 
        //         if (t.Item2 > 1)
        //             return t.Item2.ToString() + t.Item1.ToString();
        //         else 
        //             return t.Item1.ToString();
        //     })
        //     .Aggregate((a,b) => a + b);
    }

    public static string _Encode(string input)
    {
        if (input.Length == 0)
        {
            return input;
        }

        var count = 1;
        string encodedString = string.Empty;

        for (int i = 0; i < input.Length - 1; i++)
        {
            if (input[i] == input[i + 1])
            {
                count++;
                
                int itNumb = (input.Length - 2);
                if (i == itNumb)
                {
                    string numb = count.ToString();
                    encodedString += numb;
                    encodedString += input[i + 1];
                }
            }
            else if (input[i] != input[i + 1])
            {
                string numb = count.ToString();

                if (count == 1)
                {
                    encodedString += input[i];
                    
                    //validate only one letter
                    if (i == input.Length - 2)
                    {
                        encodedString += input[i + 1];
                    }
                }
                else if (count > 1)
                {
                    encodedString += numb + input[i];
                }
                count = 1;
            }
        }
        return encodedString.ToString();

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


// string digits = "";
// string returnStg = "";
//         for (int i = 0; i<input.Length; i++)
//         {
//             if (char.IsDigit(input[i]))
//             {
//                 digits.Append(input[i]);
//             }

//             if (!char.IsDigit(input[i]))
//             {
//                 if (digits == "")
//                 {
//                     returnStg += input;
//                 }
//                 else
//                 {
//                     for (int j = 0; j<Convert.ToInt16(digits); j++)
//                     {
//                         returnStg += input[i];
//                     }

//                 }
//             }
//         }

// double[] arrayNumb = { 10.2149, 7.6049, 11.48462472, 5.784770, 42.25474 };

// for (int i = 0; i < arrayNumb.Length; i++)
// {
//     double multiplier = Math.Pow(10, Convert.ToDouble(2));
//     var resultForFloripa = Math.Ceiling((double)arrayNumb[i] * multiplier) / multiplier;

//     Console.WriteLine(resultForFloripa);

// }
//         return returnStg;