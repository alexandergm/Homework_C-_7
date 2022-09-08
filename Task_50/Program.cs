using System;

namespace Task_50
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите позицию строки элемента массива: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Введите позицю столбца элемента массива: ");
            int n = int.Parse(Console.ReadLine());
            int[,] array = new int[5,5];
            Console.WriteLine();
            PrintArray(FillArray(array));
            Console.WriteLine(ElementPosition(m,n));

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

            string ElementPosition(int x, int y)
            {
                string arrayPos = string.Empty;
                if(x < array.GetLength(0) && y < array.GetLength(1))
                {
                    for (int i = 0; i < array.GetLength(0); i++)
                    {
                        for (int j = 0; j < array.GetLength(1); j++)
                        {
                            if(array[i,j] == array[x,y]) 
                            {
                                arrayPos = $"Элемент на позиции {x},{y} = {array[i,j]}";
                            }
                        }      
                    }
                }
                else arrayPos = $"Элемента на позиции {x},{y} нет Вы вышли за пределы границ массива";
                return arrayPos;
            }
        }
    }
}
