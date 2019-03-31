using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_3
{
    public class Program
    {
        static void Main(string[] args)
        {
            // 1. Объявить одномерный (5 элементов ) массив с именем A и двумерный массив (3 строки, 4 столбца) дробных чисел 
            // с именем B. Заполнить одномерный массив А числами, введенными с клавиатуры пользователем, а двумерный массив 
            // В случайными числами с помощью циклов. Вывести на экран значения массивов: массива А в одну строку, массива В — 
            // в виде матрицы. Найти в данных массивах общий максимальный элемент, минимальный элемент, общую сумму всех элементов, 
            // общее произведение всех элементов, сумму четных элементов массива А, сумму нечетных столбцов массива В.

            Random rand = new Random();
            double[] A = new double[5];
            double[,] B = new double[3, 4];
            double AB = 1;
            double sumA = 0;
            double sumB = 0;
            try
            {
                Console.WriteLine("Заполнение массива А");
                for (int i = 0; i < A.Length; i++)
                {
                    Console.WriteLine($"ведите {i} элемент массива А");
                    A[i] = Convert.ToDouble(Console.ReadLine());
                    AB = AB * A[i];
                    if (i % 2 == 0)
                    {
                        sumA += A[i];
                    }
                    //Console.Clear();
                }
                for (int i = 0; i < B.GetLength(0); i++)
                {
                    for (int j = 0; j < B.GetLength(1); j++)
                    {
                        B[i, j] = Math.Round(rand.NextDouble(), 2) + rand.Next(10);
                        AB = AB * B[i, j];
                        if (j % 2 != 0)
                        {
                            sumB += B[i, j];
                        }
                    }
                }
                Console.WriteLine("Массив А");
                for (int i = 0; i < A.Length; i++)
                {
                    Console.Write($"{A[i]}" + "\t");
                }
                Console.WriteLine();
                Console.WriteLine("Массив B");
                for (int i = 0; i < B.GetLength(0); i++)
                {
                    for (int j = 0; j < B.GetLength(1); j++)
                    {
                        Console.Write($"{B[i, j]}" + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.WriteLine("Максимальный элемент массива А = " + A.Max());
                Console.WriteLine("Максимальный элемент массива B = " + B.Cast<double>().Max());
                if (B.Cast<double>().Contains(A.Max()))
                {
                    Console.WriteLine("Максимальный общий элемент в массивах = " + A.Max());
                }
                else
                {
                    Console.WriteLine("Общего максимального элемента в массивах нет ");
                }
                Console.WriteLine("Минимальный элемент массива А = " + A.Min());
                Console.WriteLine("Минимальный элемент массива B = " + B.Cast<double>().Min());
                if (A.Min() == B.Cast<double>().Min())
                {
                    Console.WriteLine("Минимальный общий элемент в массивах = " + A.Min());
                }
                else
                {
                    Console.WriteLine("Общего минимального элемента в массивах нет ");
                }
                Console.WriteLine("Сумма элементов массивов = " + (A.Sum() + B.Cast<double>().Sum()));
                Console.WriteLine("Общее произведение элементов массивов = " + AB);
                Console.WriteLine("Cуммa четных элементов массива А = " + sumA);
                Console.WriteLine("Cуммa нечетных столбцов массива В = " + sumB);
            }
            catch (Exception)
            {
                Console.WriteLine("Завершение программы");
                Environment.Exit(0);
            }            
        }
    }
}
