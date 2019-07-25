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

    Dictionary<char, Plant> plantsEnum = Enum.GetNames(typeof(Plant))
                        .ToDictionary((e => e[0]), v => (Plant)Enum.Parse(typeof(Plant), v));

    public KindergartenGarden(string diagram)
    {
        thisDiagram = diagram;
    }

    public IEnumerable<Plant> Plants(string student)
    {
        var plantas = thisDiagram.Replace("\n", "");
        var studentcount = plantas.Length / 4;
        var studentIndex = children.IndexOf(student);
        studentIndex = (studentIndex + 1) * 2 - 2;
        
        var studentPlants = plantas.Substring(studentIndex, 2);
        studentIndex = (studentcount * 2) + studentIndex;

        
        studentPlants = studentPlants + plantas.Substring(studentIndex, 2);

        return studentPlants.Select(f => plantsEnum[f]).ToArray();

    }


}