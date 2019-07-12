using System;

public static class BeerSong
{
    public static string Recite(int startBottles, int takeDown)
    {
        string answer = "";

        int stiterator = 0;

        int snditerator = 0;





        if (takeDown == 1 && startBottles - takeDown >= 2)
        {
            for (int i = 0; i < takeDown; i++)
            {
                stiterator = startBottles - i;

                snditerator = stiterator - 1;

                answer = $"{stiterator} bottles of beer on the wall, {stiterator} bottles of beer.\n" +
                $"Take one down and pass it around, {snditerator} bottles of beer on the wall.";
            }

            return answer;
        }
        else if (startBottles - takeDown == 1 && startBottles >= takeDown)
        {
            answer = "2 bottles of beer on the wall, 2 bottles of beer.\n" +
            "Take one down and pass it around, 1 bottle of beer on the wall.";

            return answer;
        }
        else if (startBottles == 1 && takeDown == 1)
        {
            answer = "1 bottle of beer on the wall, 1 bottle of beer.\n" +
            "Take it down and pass it around, no more bottles of beer on the wall.";

            return answer;

        }
        else if (startBottles - takeDown < 0 && startBottles == 0)
        {
            answer = "No more bottles of beer on the wall, no more bottles of beer.\n" +
            "Go to the store and buy some more, 99 bottles of beer on the wall.";

            return answer;
        }
        else if (takeDown > 1 && startBottles - takeDown > 0)
        {
            for (int i = 0; i < takeDown; i++)
            {
                stiterator = startBottles - i;

                snditerator = stiterator - 1;

                if (i < (takeDown - 1))
                {
                    answer = answer + $"{stiterator} bottles of beer on the wall, {stiterator} bottles of beer.\n" +
                    $"Take one down and pass it around, {snditerator} bottles of beer on the wall.\n\n";
                }
                else
                    answer = answer + $"{stiterator} bottles of beer on the wall, {stiterator} bottles of beer.\n" +
                    $"Take one down and pass it around, {snditerator} bottles of beer on the wall."; ;
            }

            return answer;
        }
        else if (startBottles < takeDown)
        {
            for (int i = 0; i < takeDown; i++)
            {
                stiterator = startBottles - i;

                snditerator = stiterator - 1;

                if (i + 1 < startBottles && startBottles == 2)
                {
                    answer = answer + $"{stiterator} bottles of beer on the wall, {stiterator} bottles of beer.\n" +
                    $"Take one down and pass it around, {snditerator} bottle of beer on the wall.\n\n";
                }
                
                if (i + 1 < startBottles && startBottles > 2)
                {
                    if(snditerator > 1)
                    {
                    answer = answer + $"{stiterator} bottles of beer on the wall, {stiterator} bottles of beer.\n" +
                    $"Take one down and pass it around, {snditerator} bottles of beer on the wall.\n\n";
                    }
                    else
                    {
                    answer = answer + $"{stiterator} bottles of beer on the wall, {stiterator} bottles of beer.\n" +
                    $"Take one down and pass it around, {snditerator} bottle of beer on the wall.\n\n";
                    
                    }
                
                }

                if (i + 1 == startBottles)
                {
                    answer = answer + "1 bottle of beer on the wall, 1 bottle of beer.\n" +
                    "Take it down and pass it around, no more bottles of beer on the wall.\n";
                }

                if( i - startBottles == 0)
                {
                    answer = answer + "\nNo more bottles of beer on the wall, no more bottles of beer.\n" +
                    "Go to the store and buy some more, 99 bottles of beer on the wall.";
                }

            }
            
            return answer;
        }
        return null;
    }
}
