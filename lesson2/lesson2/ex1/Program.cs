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

            Console.Write("Введите минимальную температуру (например 3 или 14,5): ");
            float minTemp = float.Parse(Console.ReadLine());
            Console.Write("Введите максимальную температуру: ");
            float maxTemp = float.Parse(Console.ReadLine());

            float avgTemp = (minTemp + maxTemp) / 2;

            Console.WriteLine($"Среднесуточная температура: {avgTemp}C");
        }
    }
}
