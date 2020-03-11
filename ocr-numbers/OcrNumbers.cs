using System;
using System.Collections.Generic;
using System.Linq;

public static class OcrNumbers
{
    public static string Convert(string input)
    {
        var listOfNumbersInString = new Dictionary<string, string>()
        {
            {" _ " + "| |" +"|_|" + "   ", "0"},
            {"   " + "  |" +"  |" + "   ", "1"},
            {" _ " + " _|" +"|_ " + "   ", "2"},
            {" _ " + " _|" +" _|" + "   ", "3"},
            {"   " + "|_|" +"  |" + "   ", "4"},
            {" _ " + "|_ " +" _|" + "   ", "5"},
            {" _ " + "|_ " +"|_|" + "   ", "6"},
            {" _ " + "  |" +"  |" + "   ", "7"},
            {" _ " + "|_|" +"|_|" + "   ", "8"},
            {" _ " + "|_|" +" _|" + "   ", "9"},
            {"   " + "  _" +"  |" + "   ", "?"}

        };

        var itQtyNumb = input.Replace("\n", "");

        string singleNumb;

        string multNumb = "";

        //
        if (itQtyNumb.Length % 4 != 0)
        {
            throw new ArgumentException();
        }

        else
        {
            if (itQtyNumb.Length / 4 == 3)
            {
                var itInput = input.Replace("\n", "");

                if (listOfNumbersInString.ContainsKey(itInput))
                {
                    singleNumb = listOfNumbersInString[itInput];

                    return singleNumb;
                }

                else
                {
                    throw new ArgumentException();
                }
            }

            else if (itQtyNumb.Length / 4 > 1 && itQtyNumb.Length % 3 == 0)
            {
                var listSplitedNumbInEnt = input.Split("\n");
                var numbsInStg = new string[itQtyNumb.Length / 12];

                if (listSplitedNumbInEnt.Count() > 4)
                {
                    var listMultLines = new string[listSplitedNumbInEnt.Count() / 3];

                    for (int i = 0; i < (listSplitedNumbInEnt.Count() / 3); i++)
                    {
                        for (int j = 0; j < listSplitedNumbInEnt.Count(); j+=4)
                        {
                            listMultLines[i] += listSplitedNumbInEnt[i + j];
                        }
                    }
                    listSplitedNumbInEnt = listMultLines;
                }

                for (int i = 0; i < listSplitedNumbInEnt.Count(); i++)
                {
                    var count = 0;
                    for (int j = 0; j < listSplitedNumbInEnt[i].Length; j += 3)
                    {
                        numbsInStg[count] += listSplitedNumbInEnt[i].Substring(j, 3);
                        count++;
                    }
                }

                for (int i = 0; i < numbsInStg.Length; i++)
                {
                    if (listOfNumbersInString.ContainsKey(numbsInStg[i]))
                    {
                        multNumb += listOfNumbersInString[numbsInStg[i]];
                    }
                    else
                    {
                        multNumb += "?";
                    }
                }

                if (input.Split("\n").Count() > 4)
                {
                   for (int i = 3; i < multNumb.Length - 1; i+=4)
                   {
                       multNumb = multNumb.Insert(i, ",");
                   }
                }

                return multNumb;
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
}
