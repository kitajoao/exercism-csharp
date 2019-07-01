using System;
using System.Collections.Generic;

public class GradeSchool
{
    
    public Dictionary<int, List<string>> AddInfosGradeSchool = new Dictionary<int, List<string>> ();

    public void Add(string student, int grade)
    {
        if(AddInfosGradeSchool.ContainsKey(grade))
        {
            AddInfosGradeSchool[grade].Add(student);
            AddInfosGradeSchool[grade].Sort();
        }
        else
        {
            AddInfosGradeSchool.Add(grade, new List<string> { student });
        }
    }
    public string NameStud
    {
        get;

        set;
    }
    public int ID
    {
        get;
        set;
    }
    public IEnumerable<string> Roster()
    {
        {
        List<string> NameStud = new  List<string>();

        List<int> GradeStud = new List<int>(AddInfosGradeSchool.Keys);
        
        GradeStud.Sort();
        foreach (int grade in GradeStud)
        {
            NameStud.AddRange(AddInfosGradeSchool[grade]);
        }
        return NameStud;
       }
    }
    public IEnumerable<string> Grade(int grade)
    {
        {   
        if(AddInfosGradeSchool.ContainsKey(grade))
        { 
            AddInfosGradeSchool[grade].Sort();
            return AddInfosGradeSchool[grade];
        }
        else
        
        return new List<string>();
        }
    
    }
}
