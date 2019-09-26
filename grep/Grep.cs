using System;
using System.IO;
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
}
    