using System;

public enum Direction
{
    North,
    East,
    South,
    West
}

public class RobotSimulator
{
    public RobotSimulator(Direction direction, int x, int y)
    {
        X = x;

        Y = y;

        Direction = direction;
    }

    public Direction Direction { get; set; }

    public int X { get; set; }

    public int Y { get; set; }

    public void Move(string instructions)
    {

        for (int i = 0; i < instructions.Length; i++)
        {
            int numberDirection = (int)Direction;

            if (instructions[i] == 'L')
            {
                numberDirection = numberDirection - 1;

                if (numberDirection == -1)
                {
                    numberDirection = 3;
                }
            }
            if (instructions[i] == 'R')
            {
                numberDirection = numberDirection + 1;

                if (numberDirection == 4)
                {
                    numberDirection = 0;
                }
            }

            Direction = (Direction)numberDirection;

            if (instructions[i] == 'A')
            {
                if ((int)Direction == 0)
                {
                    Y = Y + 1;
                }
                if ((int)Direction == 1)
                {
                    X = X + 1;
                }
                if ((int)Direction == 2)
                {
                    Y = Y - 1;
                }
                if ((int)Direction == 3)
                {
                    X = X - 1;
                }

            }

        }
    }
}