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
            Console.WriteLine("Введите порядковый номер текущего месяца");
            int monthNumber = Convert.ToInt32(Console.ReadLine());
            string monthName;

            switch (monthNumber)
            {
                case 1:
                    monthName = "Январь";
                    break;
                case 2:
                    monthName = "Февраль";
                    break;
                case 3:
                    monthName = "Март";
                    break;
                case 4:
                    monthName = "Апрель";
                    break;
                case 5:
                    monthName = "Май";
                    break;
                case 6:
                    monthName = "Июнь";
                    break;
                case 7:
                    monthName = "Июль";
                    break; 
                case 8:
                    monthName = "Август";
                    break;   
                case 9:
                    monthName = "Сентябрь";
                    break;                
                case 10:
                    monthName = "Октябрь";
                    break;                
                case 11:
                    monthName = "Ноябрь";
                    break;                
                case 12:
                    monthName = "Декабрь";
                    break;
                default:
                    monthName = "Вести можно только числа от 1 до 12!";
                    break;
            }
            Console.WriteLine($"{monthName}");
        }
    }
}
