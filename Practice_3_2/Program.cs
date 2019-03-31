using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_3_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            //2.	Даны 2 массива размерности M и N соответственно. Необходимо переписать в третий массив
            //      общие элементы первых двух массивов без повторений. 

            Random rand = new Random();
            Console.WriteLine("Введите размерность массива");
            Console.WriteLine("Введите М");
            var valueM = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите N");
            var valueN = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            int[] M = new int[valueM];
            int[] N = new int[valueN];

            for (int i = 0; i < M.Length; i++)
            {
                M[i] = rand.Next(15);
            }
            for (int i = 0; i < N.Length; i++)
            {
                N[i] = rand.Next(15);
                for (int j = 0; j < M.Length; j++)
                {
                    if (N[i] == M[j])
                    {
                        count++;
                    }
                }
            }
            PrintArr("Массив M", M);
            PrintArr("Массив N", N);
            if (count != 0)
            {
                int[] MN = new int[count];
                PrintArr("Массив общий", MN);
                int z = 0;
                for (int i = 0; i < N.Length; i++)
                {
                    for (int j = 0; j < M.Length; j++)
                    {
                        if ((N[i] == M[j]) && (!MN.Contains(N[i])))
                        {
                            MN[z] = N[i];
                            z++;
                        }
                    }
                }
                Array.Resize(ref MN, z);
                PrintArr("Массив общий", MN);
            }
            else
            {
                Console.WriteLine("Общих элементов в массивах нет");
            }
        }
        static void PrintArr(string text, int[] arr)
        {
            Console.WriteLine(text + ": ");
            for (int M = 0; M < arr.Length; M++)
            {
                Console.Write(arr[M] + "\t");
            }
            Console.WriteLine();
        }
    }
}
