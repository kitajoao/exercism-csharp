using System;
using System.Collections.Generic;

public static class Etl
{
    public static Dictionary<string, int> Transform(Dictionary<int, string[]> old)
    {
        
        var newETL = new Dictionary<string, int>();

        foreach (var convETL in old)
        {
            foreach(var stepETL in convETL.Value)
            {
                newETL.Add(stepETL.ToLower(), convETL.Key);
            }
        }

        return newETL;
    }       
}