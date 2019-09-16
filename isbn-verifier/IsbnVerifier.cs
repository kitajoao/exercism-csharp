using System;
using System.Collections.Generic;
using System.Linq;
public static class IsbnVerifier
{
    public static bool IsValid(string number)
    {
        var treatedArray = number.Where(x => char.IsLetterOrDigit(x)).
        Select(x => x.ToString()).ToArray();

        var treatedList = new List<string>();

        //ISBN with size diferent from 10
        if (treatedArray.Length < 10 || treatedArray.Length > 10)
        {
            return false;
        }

        for (int i = 0; i < treatedArray.Length; i++)
        {
            //condition to return false for letters in the middle of the string or a diferent letter than "X" in the end of the string
            if ((char.IsLetter(char.Parse(treatedArray[i])) && (treatedArray.Length - 1) != i) ||
            (char.IsLetter(char.Parse(treatedArray[i])) && (treatedArray.Length - 1) == i) && treatedArray[i] != "X")
            {
                return false;
            }
            //condition to add the number 10 in the List if the last char of the string with size of 10 is "X"
            else if ((treatedArray.Length - 1) == i && treatedArray[i] == "X")
            {
                treatedList.Add("10");
            }
            //add any other number in the List.
            else
            {
                treatedList.Add(treatedArray[i]);
            }
        }
        var result = 0;

        for (int i = 0; i < treatedList.Count; i++)
        {
            result += int.Parse(treatedList[i]) * (10 - i);
        }
        if (result % 11 == 0)
        {
            return true;
        }
        return false;
    }
}