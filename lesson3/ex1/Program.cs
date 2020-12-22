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
            Console.Write("Введите порядок квадратной мартрицы: ");
            byte numb = Convert.ToByte(Console.ReadLine());

            int[,] M = new int[numb,numb]; 
            Random r = new Random();

            //Заполняем матрицу значениями
            for (byte i = 0; i < numb; i++)
            {
                for (byte j = 0; j < numb; j++)
                {
                    M[i, j] = r.Next(100);
                }
            }

            //Выводим главную диагональ
            for (byte d = 0; d < numb; d++)
                Console.Write($"{M[d, d]} ");
            Console.WriteLine();

            //выводим все матрицу с подсвеченной главной диагональю
            for (byte i = 0; i < M.GetLength(0); i++)
            {
                for (byte j = 0; j < M.GetLength(1); j++)
                {
                    string curNumber = String.Format("{0,-5}", Convert.ToString(M[i,j]));
                
                    if (i == j)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(curNumber);
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    else
                        Console.Write(curNumber);
                }
                Console.WriteLine();
            }
        }
    }
}
