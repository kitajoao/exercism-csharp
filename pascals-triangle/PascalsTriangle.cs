using System;
using System.Collections.Generic;

public static class PascalsTriangle
{
    public static IEnumerable<IEnumerable<int>> Calculate(int rows)
    {
        var arrayList = new List<int[]>();
        var count = 0;
        var a = new int[count];
        for (int i = 1; i <= rows; i++)
        {
            var x = new int[i];
            for (int j = 0; j < i; j++)
            {
                if (j == 0 || j == i - 1)
                {
                    x[j] = 1;
                }
                else
                    x[j] += a[j] + a[j - 1];
            }
            count++;
            a = x;
            arrayList.Add(x);
        }
        return arrayList.ToArray();
    }

}