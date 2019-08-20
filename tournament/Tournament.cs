using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
public static class Tournament
{
    public static void Tally(Stream inStream, Stream outStream)
    {
        var readInStream = new StreamReader(inStream);

        var textInString = readInStream.ReadToEnd();

        var splittedStringsInNextLine = textInString.Split("\n");

        var matchesPlayed = new Dictionary<string, Tuple<int, int, int, int>>();

        var table = "Team                           | MP |  W |  D |  L |  P";

        for (int i = 0; i < splittedStringsInNextLine.Length; i++)
        {
            if(string.IsNullOrEmpty(splittedStringsInNextLine[i]))
            {
                break;
            }

            var iterator = splittedStringsInNextLine[i].Split(";");

            for (int j = 0; j < 2; j++)
            {
                if (!matchesPlayed.ContainsKey(iterator[j]))
                {
                    matchesPlayed.Add(iterator[j], new Tuple<int, int, int, int>(0, 0, 0, 0));
                }
            }
            if (iterator[2] == "win")
            {
                var d = matchesPlayed[iterator[0]];

                matchesPlayed[iterator[0]] = new Tuple<int, int, int, int>(d.Item1 + 1, d.Item2, d.Item3, d.Item4 + 3);

                var w = matchesPlayed[iterator[1]];
                matchesPlayed[iterator[1]] = new Tuple<int, int, int, int>(w.Item1, w.Item2, w.Item3 + 1, w.Item4);
            }
            if (iterator[2] == "draw")
            {
                var d = matchesPlayed[iterator[0]];

                matchesPlayed[iterator[0]] = new Tuple<int, int, int, int>(d.Item1, d.Item2 + 1, d.Item3, d.Item4 + 1);

                var w = matchesPlayed[iterator[1]];
                matchesPlayed[iterator[1]] = new Tuple<int, int, int, int>(w.Item1, w.Item2 + 1, w.Item3, w.Item4 + 1);
            }
            if (iterator[2] == "loss")
            {
                var d = matchesPlayed[iterator[0]];

                matchesPlayed[iterator[0]] = new Tuple<int, int, int, int>(d.Item1, d.Item2, d.Item3 + 1, d.Item4);

                var w = matchesPlayed[iterator[1]];
                matchesPlayed[iterator[1]] = new Tuple<int, int, int, int>(w.Item1 + 1, w.Item2, w.Item3, w.Item4 + 3);
            }
        }
        
                

        var tableLine = "Teams_Names             |  matchp |  wi |  dr |  ls |  pt";

        foreach(var it in matchesPlayed)
        {
            table += "\n" + tableLine.Replace("Teams_Names", it.Key)
            .Replace("matchp", (it.Value.Item1 + it.Value.Item2 + it.Value.Item3).ToString())
            .Replace("wi", it.Value.Item1.ToString())
            .Replace("dr", it.Value.Item2.ToString())
            .Replace("ls", it.Value.Item3.ToString())
            .Replace("pt", it.Value.Item4.ToString());
        } 
        Console.WriteLine(table);

         var bytes = Encoding.UTF8.GetBytes(table);
           outStream.Write(bytes, 0, bytes.Length);
    }

}

