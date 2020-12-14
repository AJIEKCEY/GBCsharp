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
            Console.Write("Введите номер месяца: ");
            byte monthNumber = Convert.ToByte(Console.ReadLine());
            
            Console.Write("Введите температуру: ");
            int temp = Convert.ToInt32(Console.ReadLine());

            if ((monthNumber == 1 || monthNumber == 2 || monthNumber == 12) && temp > 0 )
            {
                Console.WriteLine("Дождливая зима");
            }
            else
            {
                Console.WriteLine("Спасибо, эти данные невероятно важны для нас!");
            }
        }
    }
}
