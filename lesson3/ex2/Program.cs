using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] phonebook = { 
                { "Тестов Тест Тестович", "+79104586254" }, 
                { "Иванов Иван Иванович", "9664586251" },
                { "Петросян Евгений Ваганович", "4994768545" },
                { "Илон Рив Маск Эрролович", "89104545725" }, 
                { "Иммануил Кант", "9154586211" },
            };

            ConsoleKeyInfo input;

            do
            {
                Console.Clear();
                Console.Write("Введите подстроку для поиска в телефонной книге:");
                String subString = Console.ReadLine();

                for (int i = 0; i < phonebook.GetLength(0); i++)
                {
                    for (int j = 0; j < phonebook.GetLength(1); j++)
                    {
                        if (phonebook[i, j].IndexOf(subString) != -1)
                        {
                            for (int k = 0; k < phonebook.GetLength(1); k++)
                                Console.Write($"    {phonebook[i, k]}");
                            Console.WriteLine();
                        }
                    }
                }

                Console.WriteLine("Для выхода нажмите Esc или любую клавишу для продолжения!");
                input = Console.ReadKey(true);
            } while (input.Key != ConsoleKey.Escape);
            
        }
    }
}
