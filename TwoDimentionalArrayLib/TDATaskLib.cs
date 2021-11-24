using System;

namespace TwoDimentionalArrayLib
{
    public class TDATaskLib
    {
        private static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        public static (int, int) GetMinElementIndex(int[,] array)
        {
            if (array == null)
            {
                throw new ArgumentException("Array is empty");
            }
            else
            {
                int ind1 = 0;
                int ind2 = 0;
                int min = array[0, 0];
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        if (min > array[i, j])
                        {
                            min = array[i, j];
                            ind1 = i;
                            ind2 = j;
                        }
                    }
                }

                return (ind1, ind2);
            }
        }

        public static (int, int) GetMaxElementIndex(int[,] array)
        {
            if (array == null)
            {
                throw new ArgumentException("Array is empty");
            }
            else
            {
                int ind1 = 0;
                int ind2 = 0;
                int max = array[0, 0];
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        if (max < array[i, j])
                        {
                            max = array[i, j];
                            ind1 = i;
                            ind2 = j;
                        }
                    }
                }

                return (ind1, ind2);
            }
        }

        public static int GetMinElement(int[,] array)
        {
            if (array == null)
            {
                throw new ArgumentException("Array is empty");
            }
            else
            {
                var Index = GetMinElementIndex(array);
                return array[Index.Item1, Index.Item2];
            }
        }
        public static int GetMaxElement(int[,] array)
        {
            if (array == null)
            {
                throw new ArgumentException("Array is empty");
            }
            else
            {
                var Index = GetMaxElementIndex(array);
                return array[Index.Item1, Index.Item2];
            }
        }

        public static void MainDiagonalSwap(int[,] array)
        {
            if (array == null)
            {
                throw new ArgumentException("Array is empty");
            }
            else
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = i + 1; j < array.GetLength(1); j++)
                    {
                        Swap(ref array[i, j], ref array[j, i]);
                    }
                }
            }
        }
        public static int NumMaxinNeighbourElements(int[,] array)
        {
            if (array == null)
            {
                throw new ArgumentException("Array is empty");
            }
            else
            {
                int result = 0;
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        bool ind = true;
                        if (i - 1 >= 0)
                        {
                            ind = ind && (array[i, j] > array[i - 1, j]);
                        }
                        if (i + 1 < array.GetLength(0))
                        {
                            ind = ind && (array[i, j] > array[i + 1, j]);
                        }
                        if (j - 1 >= 0)
                        {
                            ind = ind && (array[i, j] > array[i, j - 1]);
                        }
                        if (j + 1 < array.GetLength(1))
                        {
                            ind = ind && (array[i, j] > array[i, j + 1]);
                        }
                        if (ind == true)
                        {
                            ++result;
                        }

                    }
                }
                return result;
            }
        }
    }
}