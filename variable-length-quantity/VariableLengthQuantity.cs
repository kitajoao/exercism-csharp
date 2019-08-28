using System;
using System.Collections.Generic;
using System.Linq;

public static class VariableLengthQuantity
{
    const uint b127 = 0x7Fu;
    public static uint[] Encode(uint[] numbers)
    {
        var outint = new List<uint>();

        foreach (var ai in numbers)
        {
            var tmpint = new List<uint>();
            uint b128 = 0x00;
            uint a = ai;

            if (a == 0)
            {
                tmpint.Add(0);
            }
            else
                while (a > 0)
                {
                    uint p = (a & b127) | b128;
                    tmpint.Add(p);
                    a = a >> 7;
                    b128 = 0x80;// this is done to avoid an if when you have in the first block of VLQ a number == 1.
                }
            tmpint.Reverse();
            outint.AddRange(tmpint);
        }
        return outint.ToArray();
    }

    public static uint[] Decode(uint[] bytes)
    {

        var outint = new List<uint>();
        uint a = 0;
        uint b128 = 0x80;
        var index = 0;
        var bytesLength = bytes.Length;

        foreach (var ai in bytes)
        {
            a <<= 7;
            a |= ai & b127;

            if ((ai & b128) == 0)
            {
                outint.Add(a);
                a = 0;
                index++;
            }
            else if ((index == bytesLength - 1) && (ai & b128) != 0)
            {
                throw new InvalidOperationException();
            }
        }
        return outint.ToArray();
    }

}
