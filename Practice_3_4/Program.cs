using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_3_4
{
    public class Program
    {
        static void Main(string[] args)
        {
            //4.	Подсчитать количество слов во введенном предложении.

            Console.WriteLine("Введите предложение ");
            string str_ = Console.ReadLine();
            Console.WriteLine(str_);
            string[] strArr = str_.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("Количество слов в предложении = " + strArr.Length);
        }
    }
}
