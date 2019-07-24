using System;
using System.Collections.Generic;
using System.Linq;

public enum Plant
{
    Violets,
    Radishes,
    Clover,
    Grass  
}

public class KindergartenGarden
{    
    
    private int plantPerStudent = 2;
    private string thisDiagram;
    private List<string> children = new List<string>(){"Alice", "Bob", "Charlie", "David",
    "Eve", "Fred", "Ginny", "Harriet","Ileana", "Joseph", "Kincaid", "Larry"};
    
    public KindergartenGarden(string diagram)
    {
        thisDiagram = diagram;        
    }

    public IEnumerable<Plant> Plants(string student)
    {
        return thisDiagram.Split('\n').Select()
    }

    
}