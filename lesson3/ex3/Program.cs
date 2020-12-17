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
            Console.WriteLine("Введите строку!");
            char[] charArr = Console.ReadLine().ToCharArray();
            Array.Reverse(charArr);
            string reversedInput = new string( charArr );
            Console.WriteLine(reversedInput);
        }
    }
}
