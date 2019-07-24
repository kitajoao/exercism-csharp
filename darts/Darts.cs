using System;

public static class Darts
{
    public static int Score(double x, double y)
    {
        // the mathematical formula below calculates the module of the distance of a point from the center of the graphic.
        // As we are working with the radius of a circle, inside the radius circle we have the same ponctuation. Therefore,
        // if the module of two numbers are up to the value of the radius, the point is not inside the circle delimited by
        // its radius.
        
        double distScore = Math.Sqrt((Math.Pow((Math.Abs(x)), 2)) + (Math.Pow((Math.Abs(y)), 2)));

        int score = 0;

        if (distScore > 10)
        {
            score = 0;
        }
        if (distScore > 5 && distScore <= 10)
        {
            score = 1;
        }
        if (distScore > 1 && distScore <= 5)
        {
            score = 5;
        }
        if (distScore >= 0 && distScore <= 1)
        {
            score = 10;
        }
    
        return score;

    }
}
