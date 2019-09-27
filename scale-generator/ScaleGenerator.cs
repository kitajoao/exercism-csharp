using System;
using System.Collections.Generic;
using System.Linq;

public static class ScaleGenerator
{
    public static string[] sharpNotes = { "A", "A#", "B", "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#" };
    public static string[] flatNotes = { "A", "Bb", "B", "C", "Db", "D", "Eb", "E", "F", "Gb", "G", "Ab" };
    public static string[] FlatKeys = { "F", "Bb", "Eb", "Ab", "Db", "Gb", "d", "g", "c", "f", "bb", "eb" };
    private enum Intervals { m = 1, M, A };
    public static string[] Chromatic(string tonic)
    {
        return Interval(tonic, "mmmmmmmmmmmm");
    }

    public static string[] Interval(string tonic, string pattern)
    {
        List<string> notesScale = new List<string>();
        List<string> scaleForSearch = new List<string>();

        if (FlatKeys.Contains(tonic))
        {
            scaleForSearch = flatNotes.ToList();
        }
        else
        {
            scaleForSearch = sharpNotes.ToList();
        }

        int baseNote;
        if (tonic.Length == 1)
        {
            baseNote = scaleForSearch.IndexOf(tonic.ToUpper());
        }
        else
        {
            char[] it = new char[2];
            it[0] = Convert.ToChar(tonic.Substring(0, 1).ToUpper());
            it[1] = tonic[1];
            baseNote = scaleForSearch.IndexOf(new String(it));
        }

        notesScale.Add(scaleForSearch[baseNote]);
        for (int i = 0; i < pattern.Length - 1; i++)
        {
            baseNote = baseNote + (int)Enum.Parse(typeof(Intervals), Convert.ToString(pattern[i]));
            if (baseNote > 11)
            {
                baseNote -= 12;
            }
            notesScale.Add(scaleForSearch[baseNote]);
        }
        return notesScale.ToArray();
    }
}


























// using System;
// using System.Collections.Generic;
// using System.Linq;

// public static class ScaleGenerator
// {
//     private static readonly string[] SharpNotes = { "A", "A#", "B", "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#" };
//     private static readonly string[] FlatNotes = { "A", "Bb", "B", "C", "Db", "D", "Eb", "E", "F", "Gb", "G", "Ab" };
//     private static readonly string[] FlatKeys = { "F", "Bb", "Eb", "Ab", "Db", "Gb", "d", "g", "c", "f", "bb", "eb" };
//     private enum Intervals { m = 1, M, A };

//     public static string[] Chromatic(string tonic)
//     {
//         return Interval(tonic, "mmmmmmmmmmmm");
//     }

//     public static string[] Interval(string tonic, string pattern)
//     {
//         List<string> result = new List<string>();

//         List<string> correctScale = new List<string>();
//         if (FlatKeys.Contains(tonic)) correctScale = FlatNotes.ToList();
//         else correctScale = SharpNotes.ToList();

//         int baseNote;

//         if (tonic.Length == 1)
//         {
//             baseNote = correctScale.IndexOf(tonic.ToUpper());
//         }
//         else
//         {
//             char[] temp = new char[2];
//             temp[0] = Convert.ToChar(tonic.Substring(0, 1).ToUpper());
//             temp[1] = tonic[1];
//             baseNote = correctScale.IndexOf(new String(temp));
//         }

//         result.Add(correctScale[baseNote]);
//         for (int i = 0; i < pattern.Length - 1; i++)
//         {
//             baseNote = baseNote + (int)Enum.Parse(typeof(Intervals), Convert.ToString(pattern[i]));
//             if (baseNote > 11) baseNote -= 12;
//             result.Add(correctScale[baseNote]);
//         }
//         return result.ToArray();
//     }
// }