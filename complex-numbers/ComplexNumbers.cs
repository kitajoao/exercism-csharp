using System;

public struct ComplexNumber
{

    private double realPart;
    private double imaginaryPart;
    public ComplexNumber(double real, double imaginary)
    {
        realPart = real;
        imaginaryPart = imaginary;
    }
    public double Real()
    {
        return realPart;
    }
    public double Imaginary()
    {
        return imaginaryPart;
    }

    public ComplexNumber Mul(ComplexNumber other)
    {

        var multReal = Real() * other.Real() - Imaginary() * other.Imaginary();
        var multImag = Real() * other.Imaginary() + Imaginary() * other.Real();

        return new ComplexNumber(multReal, multImag);
    }
    public ComplexNumber Add(ComplexNumber other)
    {
        var addReal = Real() + other.Real();
        var addImag = Imaginary() + other.Imaginary();

        return new ComplexNumber(addReal, addImag);
    }
    public ComplexNumber Sub(ComplexNumber other)
    {
        var subReal = Real() - other.Real();
        var subImag = Imaginary() - other.Imaginary();

        return new ComplexNumber(subReal, subImag);
    }

    public ComplexNumber Div(ComplexNumber other)
    {
        var divReal = ((Real()* other.Real() + Imaginary()*other.Imaginary()) / (Math.Pow(other.Real(),2) + Math.Pow(other.Imaginary(), 2)));
        var divImag = ((Imaginary()* other.Real() - Real()*other.Imaginary()) / (Math.Pow(other.Real(),2) + Math.Pow(other.Imaginary(), 2)));

        return new ComplexNumber(divReal, divImag);
    }

    public double Abs()
    {
        var squarePart = Math.Pow(Real(), 2) + Math.Pow(Imaginary(), 2);
        var abs = Math.Pow(squarePart, 0.5);

        return abs;
    }

    public ComplexNumber Conjugate()
    {

        return new ComplexNumber(Real(), -Imaginary());
    }

    public ComplexNumber Exp()
    {
        var exp = Math.Exp(Real());
        var realExp = exp * Math.Cos(Imaginary());
        var imagExp = exp * Math.Sin(Imaginary());
    
        return new ComplexNumber(realExp, imagExp);
    }
}