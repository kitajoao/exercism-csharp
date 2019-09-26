using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public static class Grep
{
    public static string Match(string pattern, string flags, string[] files)
    {
        var result = new StringBuilder();

        flags = flags?.ToLowerInvariant();

        var printOnlyFileName = flags.Contains("-l");
        var printAddFileName = files.Count() > 1;
        var printLineNumber = flags.Contains("-n");

        Func<string, string, bool> compare = null;
        // build comparer
        var comparisonIgnoreCase = StringComparison.Ordinal;
        if (flags.Contains("-i")) // modify comparison
        {
            comparisonIgnoreCase = StringComparison.InvariantCultureIgnoreCase;
        }
        
        if (flags.Contains("-x")) // only match entire lines, instead of lines that contain a match.
        {
            if (flags.Contains("-v")) // collect all lines that fail to match the pattern
            {
                compare = (p, line) => !string.Equals(p, line, comparisonIgnoreCase);
            }
            else
            {
                compare = (p, line) => string.Equals(p, line, comparisonIgnoreCase);
            }
        }
        else // match on any part of the line
        {
            if (flags.Contains("-v")) // collect all lines that fail to match the pattern
            {
                compare = (p, line) => !line.Contains(p, comparisonIgnoreCase);
            }
            else
            {
                compare = (p, line) => line.Contains(p, comparisonIgnoreCase);
            }
        }

        // read all lines in the string[] file
        foreach (var fileName in files)
        {
            using (var r = new StreamReader(fileName))
            {
                string line;
                int lineNumber = 0;
                // read each line of the file;
                while ((line = r.ReadLine()) != null)
                {
                    lineNumber++;                    
                    if (compare(pattern, line)) // execute comparison and print output
                    {
                        // print file name
                        if (printOnlyFileName && result.ToString().Contains(fileName) == false)
                        {
                            result.Append($"{fileName}\n");
                        }
                        else if (!printOnlyFileName)
                        {
                            // print file name, line number, line
                            result.Append($"{(printAddFileName ? $"{fileName}:" : string.Empty)}{(printLineNumber ? $"{lineNumber}:" : string.Empty)}{line}\n");
                        }
                    }
                }
            }
        }

        return result
                .ToString()
                .TrimEnd(Environment.NewLine.ToCharArray());
    }

    public static string Match1(string pattern, string flags, string[] files)
    {
        string[] allFlags = flags.Split(" ");

        var resultInList = new List<string>();
        string result = String.Empty;
        var validationEquals = new List<bool>();
        var typesFlags = new string[] {"-l", "-i", "-x", "-v", "-n"};


        // allFlags = allFlags.OrderBy(i => typesFlags).ToArray();

        //read all different flags
        for (int i = 0; i < allFlags.Length; i++)
        {
            //read all lines in the string[] file
            foreach (var item in files)
            {
                long count = 0;
                using (StreamReader r = new StreamReader(item))
                {
                    string line;
                    //read each line of the file;
                    while ((line = r.ReadLine()) != null)
                    {
                        count++;
                        if (allFlags[i] == "" && line.Contains(pattern))
                        {
                            validationEquals.Add(true);
                            resultInList.Add(line);
                        }
                        else if (allFlags[i] == "-i" && line.ToLower().Contains(pattern.ToLower()))
                        {
                            validationEquals.Add(true);
                            resultInList.Add(line);
                        }
                        else if (allFlags[i] == "-n" && allFlags.Contains("-l") == false && line.Contains(pattern))
                        {
                            validationEquals.Add(true);
                            string it = count.ToString() + ":" + line;
                            resultInList.Add(it);
                        }
                        else if (allFlags[i] == "-l" && line.Contains(pattern))
                        {
                            validationEquals.Add(true);
                            result += item;
                        }
                        else if (allFlags[i] == "-x" && line == pattern)
                        {
                            validationEquals.Add(true);
                            result += line;
                        }
                        else if (allFlags[i] == "-v")
                        {
                            if (line.Contains(pattern))
                            {
                                continue;
                            }
                            else
                            {
                                validationEquals.Add(true);
                                resultInList.Add(line);
                            }
                        }
                        else
                            validationEquals.Add(false);
                    }
                }
            }

        }
        for (int i = 0; i < resultInList.Count; i++)
        {
            if ((resultInList.Count - 1) != i)
            {
                result += resultInList[i] + "\n";
            }
            else
                result += resultInList[i];
        }
        return result;
    }
}

// public static string MatchNoFlag(string pattern, string[] files)
// {
//     var resultInList = new List<string>();
//     string result = String.Empty;

//     foreach (var item in files)
//     {
//         using (StreamReader r = new StreamReader(item))
//         {
//             string line;
//             while ((line = r.ReadLine()) != null)
//             {
//                 if (line.Contains(pattern))
//                 {
//                     resultInList.Add(line);
//                 }
//             }
//         }
//     }
//     for (int i = 0; i < resultInList.Count; i++)
//     {
//         if ((resultInList.Count - 1) != i)
//         {
//             result += resultInList[i] + "\n";
//         }
//         else
//             result += resultInList[i];
//     }
//     return result;

// public static string MatchFlagN(string pattern, string[] files)
// {
//     var resultInList = new List<string>();
//     string result = String.Empty;
//     long count = 0;
//     foreach (var item in files)
//     {
//         using (StreamReader r = new StreamReader(item))
//         {
//             string line;
//             while ((line = r.ReadLine()) != null)
//             {
//                 count++;

//                 if (line.Contains(pattern))
//                 {
//                     string it = count.ToString() + ":" + line;
//                     resultInList.Add(it);
//                 }
//             }
//         }
//     }
//     for (int i = 0; i < resultInList.Count; i++)
//     {
//         if ((resultInList.Count - 1) != i)
//         {
//             result += resultInList[i] + "\n";
//         }
//         else
//             result += resultInList[i];
//     }
//     return result;
// }
// public static string MatchFlagI(string pattern, string[] files)
// {
//     var resultInList = new List<string>();
//     string result = String.Empty;
//     foreach (var item in files)
//     {
//         using (StreamReader r = new StreamReader(item))
//         {
//             string line;
//             while ((line = r.ReadLine()) != null)
//             {
//                 if (line.ToLower().Contains(pattern.ToLower()))
//                 {
//                     resultInList.Add(line);
//                 }

//             }
//         }
//     }
//     for (int i = 0; i < resultInList.Count; i++)
//     {
//         if ((resultInList.Count - 1) != i)
//         {
//             result += resultInList[i] + "\n";
//         }
//         else
//             result += resultInList[i];
//     }
//     return result;
// }
// public static string MatchFlagL(string pattern, string[] files)
// {
//     string result = String.Empty;
//     foreach (var item in files)
//     {
//         using (StreamReader r = new StreamReader(item))
//         {
//             string line;
//             while ((line = r.ReadLine()) != null)
//             {
//                 if (line.Contains(pattern))
//                 {
//                     result += item;
//                 }
//             }
//         }
//     }
//     return result;
// }
// public static string MatchFlagX(string pattern, string[] files)
// {
//     string result = String.Empty;
//     foreach (var item in files)
//     {
//         using (StreamReader r = new StreamReader(item))
//         {
//             string line;
//             while ((line = r.ReadLine()) != null)
//             {
//                 if (line == pattern)
//                 {
//                     result += line;
//                 }
//             }
//         }
//     }
//     return result;
// }
// public static string MatchFlagV(string pattern, string[] files)
// {
//     var resultInList = new List<string>();
//     string result = String.Empty;

//     foreach (var item in files)
//     {
//         using (StreamReader r = new StreamReader(item))
//         {
//             string line;
//             while ((line = r.ReadLine()) != null)
//             {
//                 if (line.Contains(pattern))
//                 {
//                     continue;
//                 }
//                 else
//                     resultInList.Add(line);
//             }
//         }
//     }
//     for (int i = 0; i < resultInList.Count; i++)
//     {
//         if ((resultInList.Count - 1) != i)
//         {
//             result += resultInList[i] + "\n";
//         }
//         else
//             result += resultInList[i];
//     }
//     return result;
// }

