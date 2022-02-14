using System;


namespace Pyramid
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"Number of blocks to build a pyramid :  {CountElements(3)}"); 
            Console.WriteLine($" Block number : {GetBlockNumber(4,1,2,2)}");
           
            
            int GetBlockNumber(int baseBlockNumber, int row, int column, int level)
            {
                int result = 0;
                
                for (int i = 0;  i < level-1; i++)
                {
                    int n =(baseBlockNumber - i);
                    result += n * n;
                }

                result += (baseBlockNumber - (level-1)) * (row - 1) + column;
                return result;
            }

            int CountElements(int n)
            {
                int count = 0;

                for (int i = 1; i <= n; i++)
                {
                    count += i * i;
                }

                return count;
            }
             Console.ReadLine();
        }
    }
    
}