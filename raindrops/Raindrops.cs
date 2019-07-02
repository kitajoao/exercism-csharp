using System;
using System.Collections.Generic;


public static class Raindrops
{
    public static string Convert(int number)
    {
        
        int [] divNumbers = new int [number];//temos um problema aqui. Eu sei que o máximo divisor comum de um número, 
                                            //além de ser ele mesmo, é ele dividido por 2. O problema que temos aqui é
                                            //que ele poderia reduzir uso de performance de ir até n e poderia ir até
                                            //number/2. contudo, um monte de critérios teriam que estar alinhados, todos os locais
                                            //onde endereço a posição no array.

        string typeAnswer = "";        
        
        for(int i = 1; i < number; i++)
        {
            if(number % i == 0)
            {
                divNumbers[i-1] += i;//temos um erro aqui, pois em certas posições ele vai acumular
            }                       //valores que são nulos. Como reorganizar a string e saber o 
        }                           //tamanho dela?

        divNumbers[number - 1] = number;

        
        for(int j = 0; j < divNumbers.Length; j++)
        {
            switch ((int)divNumbers[j])
            {
                case 3:
                    typeAnswer += "Pling";
                    break;
                    
                case 5:
                    typeAnswer += "Plang";
                    break;

                case 7:
                    typeAnswer += "Plong";
                    break;
            
            }
        //  if(divNumbers[j] % 3 != 0 || divNumbers[j] % 5 != 0 || divNumbers[j] % 7 != 0)
        //  {
        //      typeAnswer += number;
        //  }
        }
        // for(int j = 0; j < divNumbers.Length; j++)
        // {
        //     if((j+1) % 3 == 0 || (j+1) % 5 == 0 || (j+1) % 7 == 0)
        //     {
        //         switch ((int)divNumbers[j])
        //         {
        //             case 3:
        //                 typeAnswer += "Pling";
        //                 break;
                       
        //             case 5:
        //                 typeAnswer += "Plang";
        //                 break;

        //             case 7:
        //                 typeAnswer += "Plong";
        //                 break;
        //                  }
        //             }
        //     else
        //     {
        //         typeAnswer += number;
        //     }
        // }
        return typeAnswer;
        
    }
}






