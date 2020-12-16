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

            Console.WriteLine("Введите натуральное число");

            long number = Convert.ToInt64(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine($"Число {number} является четным");
            } 
            else
            {
                Console.WriteLine($"Число {number} является нечетным");

            }
        }
    }
}
