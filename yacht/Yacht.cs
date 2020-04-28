using System;
using System.Collections.Generic;
using System.Linq;
public enum YachtCategory
{
    Ones = 1,
    Twos = 2,
    Threes = 3,
    Fours = 4,
    Fives = 5,
    Sixes = 6,
    FullHouse = 7,
    FourOfAKind = 8,
    LittleStraight = 9,
    BigStraight = 10,
    Choice = 11,
    Yacht = 12,
}

public static class YachtGame
{
    public static int Score(int[] dice, YachtCategory category)
    {
        var numbFound = new Dictionary<int, int>();

        var it = dice.Length;



        var diceFaces = new Dictionary<int, int>();

        foreach (var item in dice)
        {
            if (diceFaces.ContainsKey(item))
            {
                diceFaces[item]++;
            }
            else
            {
                diceFaces[item] = 1;
            }
        }

        var pointYacht = 0;
        if (YachtCategory.Yacht == category)
        {
            if (diceFaces.Values.Contains(5))
            {
                pointYacht = 50;
            }

            return pointYacht;
        }
        if (YachtCategory.Ones == category)
        {
            var pointOnes = 0;
            foreach (var key in diceFaces.Keys)
            {
                if (key == 1)
                {
                    pointOnes = diceFaces[key];
                }
            }

            return pointOnes;
        }
        if (YachtCategory.Twos == category)
        {
            var pointTwos = 0;
            foreach (var key in diceFaces.Keys)
            {
                if (key == 2)
                {
                    pointTwos = 2 * diceFaces[key];
                }
            }

            return pointTwos;
        }

        if (YachtCategory.Fours == category)
        {
            var pointFours = 0;
            foreach (var key in diceFaces.Keys)
            {
                if (key == 4)
                {
                    pointFours = 4 * diceFaces[key];
                }
            }

            return pointFours;
        }

        if (YachtCategory.Threes == category)
        {
            var pointThrees = 0;
            foreach (var key in diceFaces.Keys)
            {
                if (key == 3)
                {
                    pointThrees = 3 * diceFaces[key];
                }
            }

            return pointThrees;
        }

        if (YachtCategory.Fives == category)
        {
            var pointFives = 0;
            foreach (var key in diceFaces.Keys)
            {
                if (key == 5)
                {
                    pointFives = 5 * diceFaces[key];
                }
            }

            return pointFives;
        }
        if (YachtCategory.Sixes == category)
        {
            var pointSixes = 0;
            foreach (var key in diceFaces.Keys)
            {
                if (key == 6)
                {
                    pointSixes = 6 * diceFaces[key];
                }
            }

            return pointSixes;
        }
        if (YachtCategory.FullHouse == category)
        {
            var pointInFullHouse = 0;

            if (diceFaces.Count == 2)
            {
                foreach (var key in diceFaces)
                {
                    if (key.Value == 2 || key.Value == 3)
                    {
                        pointInFullHouse += key.Value * key.Key;
                    }

                }
            }
            return pointInFullHouse;

        }
        if (YachtCategory.FourOfAKind == category)
        {
            var pointInFourOfAKind = 0;

            if (diceFaces.Count == 2 || diceFaces.Count == 1)
            {
                foreach (var key in diceFaces)
                {
                    if (key.Value == 4)
                    {
                        pointInFourOfAKind = key.Value * key.Key;
                    }
                    if (key.Value == 5)
                    {
                        pointInFourOfAKind = 4 * key.Key;
                    }

                }
            }
            return pointInFourOfAKind;
        }
        if (YachtCategory.LittleStraight == category)
        {
            var orderedDiceList = dice.OrderByDescending(c => c).ToArray().Reverse();

            var firstDiceOfArray = dice.OrderByDescending(c => c).ToArray().Reverse().First();

            int i = 0;

            foreach (var item in orderedDiceList)
            {
                if (item == firstDiceOfArray + i)
                {
                    i++;
                }
            }

            if (firstDiceOfArray == 1 && i == 5)
            {
                return 30;
            }
            else
            {
                return 0;
            }

        }
        if (YachtCategory.BigStraight == category)
        {
            var orderedDiceList = dice.OrderByDescending(c => c).ToArray().Reverse();

            var firstDiceOfArray = dice.OrderByDescending(c => c).ToArray().Reverse().First();

            int i = 0;

            foreach (var item in orderedDiceList)
            {
                if (item == firstDiceOfArray + i)
                {
                    i++;
                }
            }
            if (firstDiceOfArray == 2 && i == 5)
            {
                return 30;
            }
            else
            {
                return 0;
            }
        }
        if (YachtCategory.Choice == category)
        {
            var pointsChoice = 0;

            foreach (var item in dice)
            {
                pointsChoice += item;
            }

            return pointsChoice;
        }

        return -1;


    }
}
