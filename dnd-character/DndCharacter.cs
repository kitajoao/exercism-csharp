using System;

public class DndCharacter
{
    public int Strength { get;set; }
    public int Dexterity { get;set; }
    public int Constitution { get;set; }
    public int Intelligence { get;set; }
    public int Wisdom { get;set; }
    public int Charisma { get;set; }
    public int Hitpoints { get;set; }

    public static Random randomNumber = new Random();

    public static int Modifier(int score)
    {
        return (int)Math.Floor(((double)score - 10) / 2);;
    }

    public static int Ability()
    {
        return randomNumber.Next(3, 18);
    }

    public static DndCharacter Generate()
    {
        Strength = Strength.Ability();
        Dexterity = Dexterity.Ability();
        Constitution = Constitution.Ability();
        Intelligence = Intelligence.Ability();
        Wisdom = Wisdom.Ability();
        Charisma = Charisma.Ability();
        Hitpoints = 10 + Modifier();

    }
}
