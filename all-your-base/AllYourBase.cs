using System;
using System.Collections.Generic;
using System.Linq;
public static class AllYourBase
{
    public static int[] Rebase(int inputBase, int[] inputDigits, int outputBase)
    {
        var result = new List<int>();
        if (inputBase <= 1 || outputBase <= 1)
        {
            throw new ArgumentException();
        }

        else if (inputDigits.Length == 0)
        {
            result.Add(0);
        }
        else
        {
            //find de number base.
            var numberFromBase = 0;
            var itNumbFromBase = 0;
            for (var i = 0; i < inputDigits.Length; i++)
            {
                if (inputDigits[i] < 0)
                {
                    throw new ArgumentException();
                }
                var itsNumbFromBase = inputDigits[i] * (int)Math.Pow(inputBase, (inputDigits.Length - 1 - i));
                
                if(itNumbFromBase > 0 && itsNumbFromBase >= itNumbFromBase && i > 0)
                {
                    throw new ArgumentException();
                }
                numberFromBase += itsNumbFromBase;
                itNumbFromBase = itsNumbFromBase;
            }
            if (numberFromBase == 0)
            {
                result.Add(0);
            }
            else
            {
                var itForMaxPow = 0;
                var it = 0;
                var it2NumbFromBase = numberFromBase;
                var itResultIteractor = 0;
                var interDivison = 0;
                //find number of iteractions
                do
                {
                    itForMaxPow = (int)Math.Pow(outputBase, it);
                    it++;
                } while (numberFromBase >= itForMaxPow);
                // find the array
                for (int i = 0; i < it - 1; i++)
                {
                    itResultIteractor = (int)Math.Pow(outputBase, (it - 2 - i));
                    interDivison = it2NumbFromBase / itResultIteractor;

                    result.Add(interDivison);
                    it2NumbFromBase = it2NumbFromBase % itResultIteractor;
                }
            }
        }
        return result.ToArray();
    }
}
