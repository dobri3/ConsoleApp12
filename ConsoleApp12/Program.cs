using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int a = 0;
            int b = 0; 
            int[] arr = new int[5]; 

            int[,] array = new int[5, 5];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i,j] = rnd.Next(10, 20);

                    Console.Write($"{array[i,j]} " );
                }
                Console.WriteLine();
            }

            for (int i = 0;i < array.GetLength(0); i++)
            {
                for(int j = 0;j < array.GetLength(1); j++)
                {
                    if (j == 0)
                    {
                        arr[i] = array[i,j];    
                    }
                }
            }

            Console.WriteLine("Одномерный массив из первого столбца");

            foreach (var item in arr)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();

            Array.Reverse(arr);

            Console.WriteLine("Отсортированный массив");

            foreach (var item in arr)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (j == 0)
                    {
                        array[i, j] = arr[i];
                    }
                }
            }

            Console.WriteLine("Измененный первый массиы");

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {

                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine($"Значкение 3 столбца = {a}");
            Thread.Sleep(50000);
        }


    }
}
