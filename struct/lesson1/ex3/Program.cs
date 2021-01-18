using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите порядковый номер числа из последовательности Фибоначи: ");
            int number = int.Parse(Console.ReadLine());
            number--;
            Console.WriteLine(FibonachiR(number));
            Console.WriteLine(Fibonachi(number));
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

        static int Fibonachi(int n)
        {
            int a = 0, b = 1, c = 0;

            if (n == 0 || n == 1) return n;

            for (int i = 2; i <= n; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }

            return b;
        }
    }
}
