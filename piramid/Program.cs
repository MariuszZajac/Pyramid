using System;
using System.Collections;
using System.Collections.Generic;

namespace piramid
{
    class Program
    {
       public static void Main(string[] args)
       {
           int[] values;//all numbers block in piramiid
           var oneValue = new ArrayList(values);
           var list = (IList<int>) oneValue; //Add block number to list
           
           
           
           ArrayList piramidList = new ArrayList();
          
           
           
           List<int> piramidIntList = new List<int>();
           

            /* int givenLength = 6;
             int[,] composedMatrice = new int[givenLength, givenLength];
             int number = 0;
             for (int i = 0; i < composedMatrice.GetLength(0); i++)
             {
                 number = 0;
                 for (var j = 0; j < composedMatrice.GetLength(1); j++)
                 {
                     composedMatrice[i, j] = number++;
                 }
             }
 
             for (var i = 0; i < composedMatrice.GetLength(0); i++)
             {
                 for (var j = 0; j < composedMatrice.GetLength(1); j++)
                 {
                     Console.Write(
                         composedMatrice[i, j]);
                     Console.Write(" ");
                 }
 
                 Console.WriteLine("");
             }
             
 
             Console.ReadLine();
         }*/

            Console.WriteLine(CountElements(4));
            Console.WriteLine(PiramidCreate(4);

           

             int CountElements(int n)
            {
                int count = 0;
                
                for (int i = 1; i <= n; i++)
                {
                    count += i * i;
                }

                return count;
            }

             void PiramidCreate(int n)
             {
               
                 
                 int[][,] Piramid = new int[n][,]
                 {
                     new int[,] {{7, 8, 9}, {4, 5, 6}, {1, 2, 3}},
                     new int[,] {{10, 11}, {12, 13}},
                     new int[,] {{14}}
                 };
             }
             
             

             Console.ReadLine();
        }
    }
}