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
            byte calls = 4; // Кол-во вызовов метода GetFullName согласно условиям задачи

            for (byte i = 0; i < calls; i++)
            {
                string firstName = GetFirstName();
                string lastName = GetLastName();
                string patronymic = GetPatronymic();

                Console.WriteLine($"{GetFullName(firstName, lastName, patronymic)}");
                Console.WriteLine();
            }
        }

        static string GetFirstName()
        {
            Console.Write("Введите имя:");
            return Console.ReadLine();
        }

        static string GetLastName()
        {
            Console.Write("Введите фамилию:");
            return Console.ReadLine();
        }

        static string GetPatronymic()
        {
            Console.Write("Введите отчество:");
            return Console.ReadLine();
        }

        static string GetFullName(string firstName, string lastName, string patronymic)
        {
            return $"{lastName} {firstName} {patronymic}";
        }
    }
}
