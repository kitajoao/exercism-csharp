using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

public static class Luhn
{
    public static bool IsValid(string number)
    {

        

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
            convStep.Append(stgWithOnlyNumb[i]);
        }
        string treatedStg = convStep.ToString();

        //verify conditions of the string (special char, letters, low size)
       
        if (treatedStg.Length < 2)
        {
            return false;
        }
        if (stgWithOnlyNumb.Length != stepNumb.Length)
        {
            return false;
        }
    
        // start doing the validations of the Luhn
        var numbSum = 0;
        for (int i = 0; i < treatedStg.Length; i++)
        {
            var itNumb = Convert.ToInt32(new string(treatedStg[i], 1));

            if ((i + 1) % 2 == 0)
            {
                itNumb = itNumb *2;

                if(itNumb > 9)
                {
                    itNumb = 1 + itNumb - 10;
                }
            }
            
            numbSum += itNumb;

        }

        if (numbSum % 10 == 0)
        {
            return true;
        }
        return false;
    }
}


