using System;
using TwoDimentionalArrayLib;

namespace HomeWork_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[4, 4];
            Random random = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(1, 20);
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine(TDATaskLib.GetMinElement(array));
            Console.WriteLine(TDATaskLib.GetMaxElement(array));
            Console.WriteLine(TDATaskLib.GetMinElementIndex(array));
            Console.WriteLine(TDATaskLib.GetMaxElementIndex(array));
            Console.WriteLine(TDATaskLib.NumMaxinNeighbourElements(array));
            TDATaskLib.MainDiagonalSwap(array);

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {

                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }

}
