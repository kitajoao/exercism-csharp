using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;


public static class RunLengthEncoding
{
    public static string Encode(string input)
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
        throw new NotImplementedException("You need to implement this function.");
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