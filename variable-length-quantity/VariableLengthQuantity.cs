using System;
using System.Collections.Generic;
using System.Linq;

public static class VariableLengthQuantity
{
    public static uint[] Encode(uint[] numbers)
    {

        uint curNumb, index, lower7bits;

        bool end;

        var outputList = new List<uint>();

        var outputListRange = new List<uint>();


        for (int i = 0; i < numbers.Length; i++)
        {
            curNumb = numbers[i];

            end = false;

            index = 1;

            while (!end)
            {
                lower7bits = curNumb & 127;
                curNumb >>= 7;
                Console.WriteLine(lower7bits);
                if (curNumb == 0)
                {
                    end = true;
                }
                if (index != 1)
                {
                    lower7bits |= 128;
                }
                outputListRange.Add(lower7bits);
                index++;
            }
            outputListRange.Reverse();

            outputList.AddRange(outputListRange);

            outputListRange.Clear();
        }
        return outputList.ToArray();

    }
    public static uint[] Decode(uint[] bytes)
    {
        var outputList = new List<uint>();
        uint currentByte, value = 0;
        for (int i = 0; i < bytes.Length; i++)
        {
            currentByte = bytes[i];
            value <<= 7;
            value |= currentByte & 127;
            if ((currentByte & 128) == 0)
            {
                outputList.Add(value);
                value = 0;
            }
            else if (i == bytes.Length - 1 && (currentByte & 128) != 0)
            {
                throw new InvalidOperationException();
            }
        }
        return outputList.ToArray();
    }

}


