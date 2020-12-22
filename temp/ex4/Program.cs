using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите порядковый номер числа из последовательности Фибоначи: ");
            int number = int.Parse(Console.ReadLine());
            number--;
            Console.WriteLine(FibonachiR(number));
        }

        static int FibonachiR(int n)
        {
            if (n == 0 || n == 1)
            {
                return n;
            }
            else
            {
                return FibonachiR(n - 1) + FibonachiR(n - 2);
            }
        }
    }
}
