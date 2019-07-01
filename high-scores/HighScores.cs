using System;
using System.Collections.Generic;
using System.Linq;

public class HighScores
{
   
    private readonly List<int>_allscores;

    public HighScores(List<int> list)
    {
        _allscores=list;
    }
    public List<int>Scores()
    {
        return _allscores;
    }
    public int Latest()
    {
        return _allscores.Last();
    }

    public int PersonalBest()
    {
        return _allscores.Max();
    }

    public List<int> PersonalTopThree()
    {
        return _allscores.OrderByDescending(i => i).Take(3).ToList();
    }
}