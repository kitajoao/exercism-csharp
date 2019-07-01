using System;

public class SpaceAge
{
    int AgeOnSeconds;

    public SpaceAge(int seconds)
    {
        AgeOnSeconds=seconds;
    }
    public double OnEarth()
    {
        double YearOnEarthSeconds = 31557600;   
        
        double AgeOnEarth = AgeOnSeconds/YearOnEarthSeconds;
    
        return AgeOnEarth;
    }

    
    public double OnMercury()
    {
        double YearOnMercurySeconds = 0.2408467*31557600;

        double AgeOnMercury = AgeOnSeconds/YearOnMercurySeconds;
    
        return AgeOnMercury;
    }

    public double OnVenus()
    {
        double YearOnVenusSeconds = 0.61519726*31557600;

        double AgeOnVenus = AgeOnSeconds/YearOnVenusSeconds;
    
        return AgeOnVenus;
    }

    public double OnMars()
    {
        double YearOnMarsSeconds = 1.8808158*31557600;

        double AgeOnMars = AgeOnSeconds/YearOnMarsSeconds;
    
        return AgeOnMars;
    }

    public double OnJupiter()
    {
        double YearOnJupiterSeconds = 11.862615*31557600;

        double AgeOnJupiter = AgeOnSeconds/YearOnJupiterSeconds;
    
        return AgeOnJupiter;
    }

    public double OnSaturn()
    {
        double YearOnSaturnSeconds = 29.447498*31557600;

        double AgeOnSaturn = AgeOnSeconds/YearOnSaturnSeconds;
    
        return AgeOnSaturn;
    }

    public double OnUranus()
    {

        double YearOnUranusSeconds = 84.016846*31557600;

        double AgeOnUranus = AgeOnSeconds/YearOnUranusSeconds;
    
        return AgeOnUranus;
    }

    public double OnNeptune()
    {
        double YearOnNeptuneSeconds = 164.79132*31557600;

        double AgeOnNeptune = AgeOnSeconds/YearOnNeptuneSeconds;
    
        return AgeOnNeptune;
    }
}