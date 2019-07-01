using System.Collections.Generic;
using System;

public enum Allergen
{
    Eggs = 1,
    Peanuts = 2,
    Shellfish = 4,
    Strawberries = 8,
    Tomatoes = 16,
    Chocolate = 32,
    Pollen = 64,
    Cats = 128
}

public class Allergies
{

    private readonly int scoallergy;

    public Allergies(int mask)
    {        
        scoallergy = mask;
    }

    public bool IsAllergicTo(Allergen allergen)
    {
        return (scoallergy & (int)allergen) > 0;
    }

    public Allergen[] List()
    {
        if (scoallergy == 0)
        {
            return new Allergen[]{};
        }
    }
}