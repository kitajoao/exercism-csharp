using System;
using System.Collections.Generic;
using System.Linq;

public static class BookStore
{
    public static decimal Total(IEnumerable<int> books)
    {
        double priceBooks = 0;
        int countBookTypes = 0;
        int inter = 0;

        var grouped = books
                        .GroupBy(i => i)
                        .Select(i => new { Book = i.Key, Count = i.Count() })
                        .ToList();

        var qtyOfBooks = books.Count();


        if (qtyOfBooks % 8 == 0 & grouped.Count() >= 4)
        {
            for (int i = 0; i < qtyOfBooks / 4; i++)
            {
                priceBooks += 4 * 8 * 0.80;
            }
        }
        else
        {

            do
            {
                inter = 0;
                countBookTypes = grouped.Count();

                if (grouped.Count <= 5)
                {
                    if (countBookTypes == 5)
                    {
                        priceBooks += 5 * 8 * 0.75;
                    }
                    else if (countBookTypes == 4)
                    {
                        priceBooks += 4 * 8 * 0.80;
                    }
                    else if (countBookTypes == 3)
                    {
                        priceBooks += 3 * 8 * 0.90;
                    }
                    else if (countBookTypes == 2)
                    {
                        priceBooks += 2 * 8 * 0.95;
                    }
                    else if (countBookTypes == 1)
                        priceBooks += 8;
                    else
                        priceBooks += 0;
                    for (var i = 0; i < countBookTypes; i++)
                    {
                        if (grouped[i - inter].Count > 0)
                        {
                            grouped[i - inter] = new
                            {
                                Book = grouped[i - inter].Book,
                                Count = grouped[i - inter].Count - 1
                            };
                        }
                        if (grouped[i - inter].Count == 0)
                        {
                            grouped.Remove(grouped.ElementAt(i - inter));
                            inter++;
                        }
                    }
                }

            } while (grouped.Count > 0);
        }

        return (decimal)priceBooks;
    }
}
