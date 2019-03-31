using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_3_5
{
    public class Program
    {
        static void Main(string[] args)
        {
            //5.	Дан двумерный массив размерностью 5×5, заполненный случайными числами 
            //из диапазона от –100 до 100. Определить сумму элементов массива, расположенных
            //между минимальным и максимальным элементами.

            Random rand = new Random();
            int[,] A = new int[5, 5];
            int sumA = 0, max = A[0, 0], min = A[0, 0];
            int a = 0, b = 0, c = 0, d = 0;
            bool t = false;
            try
            {
                Console.WriteLine("Заполнение массива А");
                Console.WriteLine("Массив B");
                for (int i = 0; i < A.GetLength(0); i++)
                {
                    for (int j = 0; j < A.GetLength(1); j++)
                    {
                        A[i, j] = rand.Next(-100, 100);
                        if (max < A[i, j])
                        {
                            max = A[i, j];
                            a = i;
                            b = j;
                        }
                        if (min > A[i, j])
                        {
                            min = A[i, j];
                            c = i;
                            d = j;
                        }
                        Console.Write($"{A[i, j]}\t");
                    }
                    Console.WriteLine();
                }
                for (int i = 0; i < A.GetLength(0); i++)
                {
                    for (int j = 0; j < A.GetLength(1); j++)
                    {
                        if ((i == a && j == b) || (i == c && j == d))
                        {
                            if (t)
                            {
                                t = false;
                                continue;
                            }
                            else
                            {
                                t = true;
                                continue;
                            }
                        }
                        if (t)
                        {
                            sumA += A[i, j];
                        }
                    }
                }
                Console.WriteLine();
                Console.WriteLine("Максимальный элемент массива B = " + max);
                Console.WriteLine("Минимальный элемент массива B = " + min);
                Console.WriteLine("Cуммa элементов массива, расположенных между минимальным и максимальным элементами = " + sumA);
            }
            catch (Exception)
            {
                Console.WriteLine("Завершение программы");
                Environment.Exit(0);
            }
        }
    }
}
