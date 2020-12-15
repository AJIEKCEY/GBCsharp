using System;
using System.ComponentModel;
using System.Reflection;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    class Program
    {
        public enum Month
        {
            [Description("Январь")]
            January = 1,
            [Description("Февраль")]
            February,
            [Description("Март")]
            March,
            [Description("Апрель")]
            April,
            [Description("Май")]
            May,
            [Description("Июнь")]
            June,
            [Description("Июль")]
            July,
            [Description("Август")]
            August,
            [Description("Сентябрь")]
            September,
            [Description("Октябрь")]
            October,
            [Description("Ноябрь")]
            November,
            [Description("Декабрь")]
            December
        }
        static void Main(string[] args)
        {

            //TODO написать метод получения значения из description

            do
            {
                
                Console.Write("Введите порядковый номер текущего месяца:");

                int monthNumber = Convert.ToInt32(Console.ReadLine());

                if (monthNumber > 12 || monthNumber < 1)
                {
                    Console.WriteLine("Вы ошиблись, такого месяца не существует. Попробуйте еще раз!");
                }
                else
                {
                    Month monthName = (Month)(monthNumber);
                    Console.WriteLine($"Сейчас на дворе {monthName}");
                    break;
                }

                Console.WriteLine("Для выхода нажмите Esc");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
