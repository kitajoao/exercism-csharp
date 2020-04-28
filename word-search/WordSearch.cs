using System;
using System.Collections.Generic;
using System.Linq;

public class WordSearch
{

    public string wordsWhereToLookFor;
    public WordSearch(string grid)
    {
        wordsWhereToLookFor = grid;
    }


    public Dictionary<string, ((int, int), (int, int))?> Search(string[] wordsToSearchFor)
    {

        string[] toLook = wordsWhereToLookFor.Split("\n");

        Dictionary<string, ((int, int), (int, int))?> result = new Dictionary<string, ((int, int), (int, int))?>();


        // looking in normal order
        for (int i = 0; i < wordsToSearchFor.Count(); i++)
        {
            for (int j = 0; j < toLook.Count(); j++)
            {

                int n = toLook[j].Length;
                int m = wordsToSearchFor[i].Length;
                var it = toLook[j];
                var toFind = wordsToSearchFor[i];


                for (int k = 0; k <= n - m; k++)
                {
                    int l;

                    for (l = 0; l < m; l++)
                    {
                        if (it[k + l] != toFind[l])
                        {
                            break;
                        }
                        if (l == (m - 1))
                        {
                            result.Add(toFind, (((k + 1), (j + 1)), ((k + l + 1), (j + 1))));
                        }
                    }
                }
            }
        }

        //searching in reverse
        for (int i = 0; i < wordsToSearchFor.Count(); i++)
        {
            for (int j = 0; j < toLook.Count(); j++)
            {
                int n = toLook[j].Length;
                int m = wordsToSearchFor[i].Length;
                var it = toLook[j];
                var toFind = wordsToSearchFor[i];

                for (int k = n - 1; k > n - m; k--)
                {
                    int l;

                    for (l = 0; l < m; l++)
                    {
                        if (it[k - l] != toFind[l])
                        {
                            break;
                        }
                        if (l == m - 1)
                        {
                            result.Add(toFind, (((k + 1), (j + 1)), ((k - l + 1), (j + 1))));
                        }
                    }
                }
            }
        }

        //read in vertical from up to down
        for (int i = 0; i < wordsToSearchFor.Count(); i++)
        {
            int m = wordsToSearchFor[i].Length;
            var toFind = wordsToSearchFor[i];

            if(toLook.Count() == 1)
            {
                break;
            }
            //itera coluna por coluna
            for (int j = 0; j < toLook[0].Length; j++)
            {
                //itera linha por linha
                for (int k = 0; k < toLook.Count(); k++)
                {
                    int l;
                    for (l = 0; l < toLook.Count() - k; l++)
                    {
                        if (toLook[k + l][j] != toFind[l])
                        {
                            break;
                        }
                        if (l == m - 1)
                        {
                            result.Add(toFind, (((j + 1), (k + 1)), ((k + l + 1), (j + 1))));
                        }
                    }
                }
            }
        }

        for (int i = 0; i < wordsToSearchFor.Count(); i++)
        {
            int m = wordsToSearchFor[i].Length;
            var toFind = wordsToSearchFor[i];

            if(toLook.Count() == 1)
            {
                break;
            }
            //itera coluna por coluna
            for (int j = 0; j < toLook[0].Length; j++)
            {
                //itera linha por linha
                int it = 0;
                for (int k = toLook.Count()-1; k >= 0; k--)
                {
                    int l;
                    for (l = 0; l < toLook.Count() - it; l++)
                    {
                        if (toLook[k - l][j] != toFind[l])
                        {
                            break;
                        }
                        if (l == m - 1)
                        {
                            result.Add(toFind, (((j + 1), (k + 1)), ((k + l + 1), (j + 1))));
                        }
                    }
                    it++;
                }
            }
        }
        return result;

    }
}