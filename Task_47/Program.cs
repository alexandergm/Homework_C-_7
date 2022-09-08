using System;

namespace Task_47
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строк массива: ");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов массива: ");
            int n = int.Parse(Console.ReadLine());
            double[,] array = new double[m,n];
            PrintArray(FillArray(array));

            double[,] FillArray(double[,] arr)
            {
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        arr[i,j] = new Random().Next(1,100) + Math.Round(new Random().NextDouble() , 2);
                    }
                }
                return arr;
            }
            void PrintArray(double[,] arr)
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
        }
    }
}
