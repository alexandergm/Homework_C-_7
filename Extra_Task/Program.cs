﻿using System;

namespace Extra_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество строк массива: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов массива: ");
            int n = int.Parse(Console.ReadLine());
            int[,] array = new int[m,n];
            PrintArray(FillArray(array));
            SortArray();
            Console.WriteLine("Отсортированный массив: ");
            PrintArray(array);

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
            void SortArray()
            {
                int arrayMaxLength;
                if(m > n) arrayMaxLength = m;
                else arrayMaxLength = n;                
                int[] temp = new int[arrayMaxLength];

                for (int i = 0; i < array.GetLength(0); i++)
                { 
                    for (int j = 0; j < array.GetLength(1); j++)  temp[j] = array[i, j];                        
                    Array.Sort(temp);

                    for (int k = 0; k < array.GetLength(1); k++) array[i, k] = temp[k];                                     
                }    
                
                for (int i = 0; i < array.GetLength(1); i++)
                {
                    for (int j = 0; j < array.GetLength(0); j++)  temp[j] = array[j, i];                        
                    Array.Sort(temp);

                    for (int k = 0; k < array.GetLength(0); k++) array[k, i] = temp[k];                        
                }
            }
        }
    }
}
