using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите натуральное число:");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(isPrime(number));
        }

        private static bool isPrime(int n)
        {
            int d = 0;
            int i = 2;

            while (i < n)
            {
                if (n % i == 0)
                {
                    d++;
                }
                i++;
            }
            return d == 0;
        }
    }
}
