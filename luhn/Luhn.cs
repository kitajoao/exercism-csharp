using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

public static class Luhn
{
    public static bool IsValid(string number)
    {

        //reverse array
        // char[] convStep = number.Where(c => !Char.IsLetter(c)).ToArray();
        // Array.Reverse(convStep);
        // var treatedStg = new string(convStep).Replace(" ", "");

        //verify only numbers
        StringBuilder stgWithOnlyNumb = new StringBuilder();
        string onlyNumb = @"\d";
        var stepNumb = new string(number).Replace(" ", "");

        //create a string with only numbers
        foreach (Match m in Regex.Matches(stepNumb, onlyNumb))
        {
            stgWithOnlyNumb.Append(m);
        }

        StringBuilder convStep = new StringBuilder();
        for (int i = stgWithOnlyNumb.Length - 1; i >= 0; i--)
        {
            Console.WriteLine($"step string: {stgWithOnlyNumb[i]}");
            convStep.Append(stgWithOnlyNumb[i]);
        }
        string treatedStg = convStep.ToString();

        //verify conditions of the string (special char, letters, low size)
        // Console.WriteLine($" treatedStg is: {treatedStg}.");
        if (treatedStg.Length < 2)
        {
            return false;
        }
        if (stgWithOnlyNumb.Length != stepNumb.Length)
        {
            return false;
        }
    
        var numbSum = 0;
        for (int i = 0; i < treatedStg.Length; i++)
        {
            // Console.WriteLine($"char in position {i} is equal to {stgWithOnlyNumb[i]}");
            var itNumb = Convert.ToInt32(new string(treatedStg[i], 1));

            Console.WriteLine($"itNumb is equal to {itNumb}");
            
            if ((i + 1) % 2 == 0)
            {
                itNumb = itNumb *2;

            Console.WriteLine($"itNumb is equal to {itNumb}");
                if(itNumb > 9)
                {
                    itNumb = 1 + itNumb - 10;
                }
            }
            
            
            numbSum += itNumb;
            // Console.WriteLine($"numbSum is equal to {numbSum}");

        }

        if (numbSum % 10 == 0)
        {
            return true;
        }


        return false;
    }
}




// using System;
// using System.Collections.Generic;
// using System.Linq;


// public static class Luhn
// {
//     public static bool IsValid(string number)
//     {
//         //reverse array
//         // char[] convStep = number.Where(c => !Char.IsLetter(c)).ToArray();
//         // Array.Reverse(convStep);
//         //remove spaces from
//         var treatedStg = number.Replace(" ", "");

//         if (treatedStg.Length < 2)
//         {
//             return false;
//         }
//         // Console.WriteLine($"Values different from a number {number.Any(x => char.IsLetter(x))}");
//         // Console.WriteLine($"Values different from a number {number.Any(x => char.IsLetter(x))}");



//         long numbInInt;

//         var x = long.TryParse(treatedStg, out numbInInt);



//         if (x)
//         {
//             var convStep = treatedStg.Where(c => !Char.IsLetter(c)).Reverse().ToArray();

//             long lengthOfString = new string(convStep).Length - 1;

//             long tenPow = (long)Math.Pow(10, lengthOfString);

//             int count = 1;
//             long numbSum = 0;
//             Console.WriteLine($"{new string(convStep)}");

//             for (int i = 0; i < lengthOfString; i++)
//             {
//                 if (tenPow == 0)
//                 {
//                     break;
//                 }

//                 if (count % 2 == 0)
//                 {
//                     var it = numbInInt / tenPow;


//                     it = it * 2;
//                     if (it > 9)
//                     {
//                         it = 1 + it - 10;
//                     }

//                     Console.WriteLine($"{it}");
//                     numbSum += it;
//                 }
//                 else
//                 {
//                     numbSum += numbInInt / tenPow;
//                 }

//                 numbInInt = numbInInt % tenPow;


//                 if (tenPow > 0)
//                 {

//                     tenPow = tenPow / 10;
//                 }
//                 count++;
//             }

//             if (numbSum % 10 == 0)
//             {
//                 return true;


//             }


//             return false;
//         }
//         else
//         {
//             Console.WriteLine($"Entrou? lalalalala  {number}");

//             return false;

//         }

//     }


//     // convert string in int
//     // if (number.Any(x => char.IsLetter(x)))
//     // {
//     //     return false;
//     // }
//     // if (number.Any(x => char.IsSymbol(x)))
//     // {
//     //     return false;
//     // }
//     //  if (number.Any(x => char.IsSymbol(x)))
//     // {
//     //     return false;
//     // }

// }