using System;

public class Queen
{
    public Queen(int row, int column)
    {
        Row = row;
        Column = column;
    }

    public int Row { get; }
    public int Column { get; }
}

public static class QueenAttack
{
    public static bool CanAttack(Queen white, Queen black)
    {
        if( white.Row == black.Row || white.Column == black.Column || ((white.Row - black.Row)/(white.Column - black.Column)) == 1 || ((white.Row - black.Row)/(white.Column - black.Column)) == -1)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static Queen Create(int row, int column)
    {

        Queen posQueen = new Queen(row, column);

        if (row < 0 || column < 0 || row > 7 || column > 7)
        {
            throw new ArgumentOutOfRangeException();
        }

        return posQueen;
    }
}