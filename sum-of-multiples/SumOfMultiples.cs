
using System;
using System.Collections.Generic;
using System.Linq;


public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
        IEnumerable<int> multi = Enumerable.Range(1, max - 1).SelectMany( 
                    e => multiples.Select( m => 
                    {
                        if (m != 0 && e % m == 0)
                            return e;
                        else 
                            return 0;
                    })
                );
        
        //Range(1, max).Select(x => x * multiples);

        return multi.Distinct().Sum();
    }
}