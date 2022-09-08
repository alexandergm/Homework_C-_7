using System;

namespace Task_52
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строк массива: ");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов массива: ");
            int n = int.Parse(Console.ReadLine());
            int[,] array = new int[m,n];
            PrintArray(FillArray(array));
            ArifmeticAverage();

            int[,] FillArray(int[,] arr)
            {
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        arr[i,j] = new Random().Next(1,100);
                    }
                }
                return arr;
            }
            void PrintArray(int[,] arr)
            {
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        Console.Write(arr[i,j] + "\t" );
                    }
                    Console.WriteLine();
                }
            }
            void ArifmeticAverage()
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    double average = 0;
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        average += array[j, i];
                    }
                    average = average / array.GetLength(1);
                    Console.WriteLine($"Arifmetic average in {i} column: {average}");
                }
            }
        }
    }
}
