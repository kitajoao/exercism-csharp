using System;
using System.Collections.Generic;

public class Robot
{
    Random randompos;
    public static List<string> UsedRobotNames = new List<string>();
    const string PossLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    string _Name;
    public Robot(){
        randompos = new Random();
        _Name = generateNameRobot();
    }
    public string Name
    {
        get
        {
            return _Name;
        }
    }

    public void Reset()
    {
        UsedRobotNames.Remove(_Name);
        _Name = generateNameRobot();
    }

    public string generateNameRobot(){
        string temp = PossLetters[randompos.Next(0,25)].ToString() + PossLetters[randompos.Next(0,25)].ToString() + randompos.Next(100,999).ToString();

        if(UsedRobotNames.Contains(temp))
        {
            temp = generateNameRobot();
        }
        UsedRobotNames.Add(temp);
        
        return temp;
    }
}