using System;

public static class House
{
    public static string[] phrases = new string[]{"the house that Jack built."/*0*/, "the malt "/*1*/, "the rat "/*2*/, "the cat "/*3*/,
        "the dog "/*4*/, "the cow with the crumpled horn "/*5*/, "the maiden all forlorn "/*6*/, "the man all tattered and torn "/*7*/,
        "the priest all shaven and shorn "/*8*/, "the rooster that crowed in the morn "/*9*/, "the farmer sowing his corn "/*10*/,
        "the horse and the hound and the horn "/*11*/};

    public static string[] head = new string[]{"This is "/*0*/, "that lay in "/*1*/, "that ate "/*2*/, "that killed "/*3*/, "that worried "/*4*/,
        "that tossed "/*5*/, "that milked "/*6*/, "that kissed "/*7*/, "that married "/*8*/, "that woke "/*9*/, "that kept "/*10*/, "that belonged to "/*11*/
        };
    public static string Recite(int verseNumber)
    {
        string answer = head[0] + phrases[verseNumber - 1];

        for (int i = 0; i < (verseNumber - 1); i++)
        {
            answer += head[verseNumber - 1 - i] + phrases[verseNumber - 2 - i];
        }
        return answer;
    }
    public static string Recite(int startVerse, int endVerse)
    {
        string answer = "";
        for (int i = (startVerse - 1); i < (endVerse); i++)
        {
            answer += head[0] + phrases[i];

            for (int j = i; j > 0; j--)
            {
                answer += head[j] + phrases[j - 1];
            }
            if (i == endVerse - 1)
            {
                break;
            }
            answer += "\n";
        }
        return answer;
    }
}