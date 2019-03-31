using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_3_3
{
    public class Program
    {
        static void Main(string[] args)
        {
            //3.	Пользователь вводит строку. Проверить, является ли эта строка палиндромом. 
            //      Палиндромом называется строка, которая одинаково читается слева направо и справа налево.

            Console.WriteLine("Введите строку в одном регистре");
            string str = Console.ReadLine();
            char[] t = new char[str.Length];
            int y = str.Length - 1;
            bool test = true;
            for (int i = 0, j = y; j >= 0 && i <= y; i++, j--)
            {
                if (str[i] == ' ')
                    i++;
                if (str[j] == ' ')
                    j--;
                if (str[i] != str[j])
                {
                    test = false;
                    break;
                }
            }
            if (test)
                Console.WriteLine("Введенный текст - палиндром");
            else
                Console.WriteLine("Введенный текст не палиндром");
        }
    }
}
