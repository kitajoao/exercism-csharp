using System;


public static class ResistorColor
{
    public static string [] COLORS = { "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white" };
    
    public static int ColorCode(string color)
        => Array.IndexOf(COLORS, color?.ToLowerInvariant());

    public static string[] Colors()
        => (string[]) COLORS.Clone();
        
    public static string ColorCode(int index)
        => COLORS[index];
}
