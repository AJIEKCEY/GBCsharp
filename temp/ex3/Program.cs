using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
    class Program
    {
        enum Seasons
        {
            Winter, 
            Spring, 
            Summer, 
            Autumn,
            Error
        }
        static void Main(string[] args)
        {
            int monthNumber = GetMonthsNumber();
            Seasons season = GetSeasonsByMonthNumber(monthNumber);
            string seasonInRus = TranslateSeasonName(season);

            Console.WriteLine(seasonInRus);
        }

        static int GetMonthsNumber()
        {
            bool isCorrectNumber = false;
            int monthsNumber;
 
            do
            {
                Console.Write("Введите порядковый номер месяца:");
                monthsNumber = Convert.ToInt32(Console.ReadLine());
                isCorrectNumber = (monthsNumber > 0 && monthsNumber < 13) ? true : false; 
                
                if (!isCorrectNumber)
                {
                    Console.WriteLine("Ошибка: введите число от 1 до 12!");
                }

            } while (!isCorrectNumber);
            return monthsNumber;
        }

        static Seasons GetSeasonsByMonthNumber(int monthNumber)
        {
            switch (monthNumber)
            {
                case 12:
                case 1:
                case 2:
                    return Seasons.Winter;
                case 3:
                case 4:
                case 5:
                    return Seasons.Spring;
                case 6:
                case 7:
                case 8:
                    return Seasons.Summer;
                case 9:
                case 10:
                case 11:
                    return Seasons.Autumn;
                default:
                    return Seasons.Error;
            }
        }

        static string TranslateSeasonName( Seasons name)
        {
            switch (name)
            {
                case Seasons.Winter:
                    return "Зима";
                case Seasons.Spring:
                    return "Весна";
                case Seasons.Summer:
                    return "Лето";
                case Seasons.Autumn:
                    return "Осень";
                default:
                    return "Ошибка: Не удалось определить время года.";
            }
        }
    }
}
