using System;

namespace piramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int givenLength = 6;
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
        }
    }
}