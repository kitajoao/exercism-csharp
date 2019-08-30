using System;
using System.Diagnostics;

public static class RealNumberExtension
{
    public static double Expreal(this int realNumber, RationalNumber r)
    {
        float power = ((float)r.num/(float)r.den);
        
        float result  = (float)Math.Pow(realNumber, power);
        
        if(result >=1)
        {
            result = (int)result;
        }
        
        return result;
    }
}

public struct RationalNumber
{
    public RationalNumber(int numerator, int denominator)
    {
        num = numerator;

        den = denominator;
    }

    public int num { get; set; }

    public int den { get; set; }
    public static RationalNumber operator +(RationalNumber r1, RationalNumber r2)
    {
        var result = new RationalNumber(((r1.num * r2.den) + (r2.num * r1.den)), (r1.den * r2.den));

        if (result.num == 0)
        {
            result = new RationalNumber(result.num, (result.den / result.den));
        }
        else if (result.num % (GCD(r1, r2)) == 0)
        {
            result = new RationalNumber((result.num / (GCD(r1, r2))), (result.den / (GCD(r1, r2))));
        }
        return result;
    }
    public static RationalNumber operator -(RationalNumber r1, RationalNumber r2)
    {
        var result = new RationalNumber(((r1.num * r2.den) - (r2.num * r1.den)), (r1.den * r2.den));


        if (result.num == 0)
        {
            result = new RationalNumber(result.num, (result.den / result.den));

        }
        else if (result.num % (GCD(r1, r2)) == 0)
        {
            result = new RationalNumber((result.num / (GCD(r1, r2))), (result.den / (GCD(r1, r2))));
        }

        return result;
    }

    public static RationalNumber operator *(RationalNumber r1, RationalNumber r2)
    {
        var result = new RationalNumber((r1.num * r2.num), (r1.den * r2.den));


        if (result.num == 0)
        {
            result = new RationalNumber(result.num, (result.den / result.den));

        }
        else if (result.num == result.den)
        {
            result = new RationalNumber((result.num / result.num), (result.den / result.den));
        }
        else if (result.num % (GCD(r1, r2)) == 0)
        {
            result = new RationalNumber((result.num / (GCD(r1, r2))), (result.den / (GCD(r1, r2))));
        }

        Console.WriteLine("result is equal to: {0}", result.num);


        return result;
    }

    public static RationalNumber operator /(RationalNumber r1, RationalNumber r2)
    {

        if (r2.num < 0)
        {
            r2.num = (-1) * r2.num;
            r1.num = (-1) * r1.num;
        }
        var result = new RationalNumber((r1.num * r2.den), (r2.num * r1.den));

        return result;
    }

    public RationalNumber Abs()
    {
        return new RationalNumber(Math.Abs(num),Math.Abs(den));
    }

    public RationalNumber Reduce()
    {
        throw new NotImplementedException("You need to implement this function.");
    }

    public RationalNumber Exprational(int power)
    {
        return new RationalNumber((int)Math.Pow(num, power),(int)Math.Pow(den, power));     
    }

    public double Expreal(int baseNumber)
    {

        throw new NotImplementedException("You need to implement this extension method.");
    }

    public static int GCD(RationalNumber r1, RationalNumber r2)
    {
        int greatestComDiv = 0;
        // Func<int, int, int> cal = (x, y) => (x % y == 0) ? x : y;

        if (r1.den < 0 && r2.den < 0)//both numbers lower than zero
        {
            greatestComDiv = (r1.den < r2.den) ? r2.den : r1.den;
        }
        else if (r1.den == 0 || r2.den == 0) //one number greater than zero and the other number lower than zero
        {
            greatestComDiv = (r1.den != 0) ? r1.den : r2.den;
        }
        else if (r1.den != 0 && r1.den < 0)//both number greater than zero.
        {
            greatestComDiv = (r1.den < r2.den) ? r1.den : r2.den;
        }
        else if (r1.den > 0 && r2.den > 0)
        {
            greatestComDiv = (r1.den > r2.den) ? r2.den : r1.den;
        }

        return greatestComDiv;
    }
}