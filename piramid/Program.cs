using System;

namespace piramid
{
    class Program
    {
       public static void Main(string[] args)
        {
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
            Console.WriteLine(PiramidCreate(4,1,2,2));

           

             int CountElements(int n)
            {
                int count = 0;
                
                for (int i = 1; i <= n; i++)
                {
                    count += i * i;
                }

                return count;
            }

             int PiramidCreate(int n, int wiersz,  int kolumna, int poziom)
             {
                 int number = 0;
                 for (int i = 0; i <= poziom; i++) 
                 {
                     number += (n - i)*(n-i) ;
                 }

                 return number + ((n - poziom) * wiersz) + kolumna;
             }

             int n = 3;
             int x = n - 1;
             int[][,] Piramid = new int[n][,]
             {
                 new int[,]{},
                 new int[,]{},
                 new int[,]{}
             };

            Console.ReadLine();
        }
    }
}