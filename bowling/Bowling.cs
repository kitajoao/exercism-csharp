using System;
using System.Collections.Generic;
using System.Linq;

public class BowlingGame
{
    private List<int> rolls = new List<int>();
    private bool firstFrame = true;
    private int rollIt;
    public List<string> frames = new List<string>();
    
    private int sumOfBallsInFrame(int currentRoll) => rolls[currentRoll] + rolls[currentRoll + 1];
    private bool IsSpare(int currentRoll) => rolls[currentRoll] + rolls[currentRoll + 1] == 10;
    private bool IsStrike(int currentRoll) => rolls[currentRoll] == 10;
    private bool IsOpenFrame(int currentRoll) => rolls[currentRoll] + rolls[currentRoll + 1] < 10;
    private bool IsValidFrame(int pins)
    {
        if(rolls.Count >= 21 || pins < 0 || pins > 10 || rolls.Count + 1 % 2 == 0
        && rolls[rolls.Count - 1] + pins > 10)
        {
            return false;
        }
        if((rolls.Count + 1) % 2 == 0 && rolls[rolls.Count -1] != 10 && rolls[rolls.Count - 1] + pins > 10)
        {
            return false;
        }
        if(rolls.Count == 20)
        {
            if(rolls[18] != 10 && rolls[18] + rolls[19] != 10)
                return false;
            
            if(pins == 10 && (rolls[18] != 10 || rolls[19] != 10 || rolls[19] + pins > 10 && rolls[19] + pins != 20)
               && rolls[18] + rolls[19] != 10)
                return false;

            if(pins != 10 && rolls[19] + pins > 10 && rolls[19] != 10)
                return false;
        }

        return true;
    }
    public void Roll(int pins)
    {    
        if(!IsValidFrame(pins))
        {
            throw new ArgumentException();
        }
        
        rolls.Add(pins);
    }

    public int? Score()
    {
        int score = 0;
        int roll = 0;

        if(rolls.Count < 12 || rolls.Count > 21)
        {
            throw new ArgumentException();
        }

        for (int frame = 0; frame < 10; frame++)
        {
            
            if(rolls.Count < roll + 2)
            {
                throw new ArgumentException();
            }

            //strike
            if (IsStrike(roll))
            {
                roll++;

                if(frame == 9 && rolls.Count - roll < 2)
                {
                    throw new ArgumentException();
                }

                score += 10 +
                         rolls[roll] + rolls[roll + 1]; //strike bonus
            }

            //spare
            else if (IsSpare(roll))
            {
                roll += 2;
                if(frame == 9 && rolls.Count - roll < 1)
                {
                    throw new ArgumentException();
                }
                
                score += 10 +
                         rolls[roll]; // spare bonus
            }
     
            //open
            else    
            {
                score += sumOfBallsInFrame(roll);
                roll += 2;
            }
        }
        return score;
    }
}
