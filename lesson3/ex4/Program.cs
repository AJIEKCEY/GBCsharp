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
            //TODO Переделать реализацию используя функции.
            //TODO Обрабатывать исключения, в частности IndexOutOfRange Exception

            byte field = 10;
            string[,] battlefield = new string[field + 1, field + 1];

            //формируем поле
            for (byte i = 0; i < battlefield.GetLength(0); i++)
            {
                if (i == 0)
                {
                    for (byte j = 1; j < battlefield.GetLength(1); j++)
                        battlefield[0, j] = (Convert.ToChar(j + 96)).ToString();
                    continue;
                }

                battlefield[i, 0] = i.ToString();
                for (byte j = 1; j < battlefield.GetLength(1); j++)
                {
                    if (battlefield[i, j] != "X")
                        battlefield[i, j] = "O";
                }
            }

            //выводим поле в консоль
            for (byte i = 0; i < battlefield.GetLength(0); i++)
            {
                for (byte j = 0; j < battlefield.GetLength(1); j++)
                {
                    string currCellVal = battlefield[i, j];
                    if (currCellVal == "X")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(String.Format("{0,-3}", currCellVal));
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    else
                    {
                        Console.Write(String.Format("{0,-3}", currCellVal));
                    }  
                }
                Console.WriteLine();
            }

            Console.WriteLine("Задайте начальную точку координат для линкора («четырёхпалубный»)(например: 4j): ");
            string userCoord = Console.ReadLine();
            Console.WriteLine("Выберите стрелкой направление размещения! ");
            ConsoleKeyInfo direction = Console.ReadKey();
            //преобразовываем введенные координаты в координаты матрицы
            byte iDemension = Byte.Parse(userCoord[0].ToString());
            byte jDemension = Convert.ToByte(Convert.ToChar(userCoord[1]) - 96);

            if (direction.Key == ConsoleKey.LeftArrow)
            {
                battlefield[iDemension, jDemension] = "X";
                battlefield[iDemension, jDemension - 1] = "X";
                battlefield[iDemension, jDemension - 2] = "X";
                battlefield[iDemension, jDemension - 3] = "X";
            }
            else if (direction.Key == ConsoleKey.RightArrow)
            {
                battlefield[iDemension, jDemension] = "X";
                battlefield[iDemension, jDemension + 1] = "X";
                battlefield[iDemension, jDemension + 2] = "X";
                battlefield[iDemension, jDemension + 3] = "X";
            }
            else if (direction.Key == ConsoleKey.UpArrow)
            {
                battlefield[iDemension, jDemension] = "X";
                battlefield[iDemension - 1, jDemension] = "X";
                battlefield[iDemension - 2, jDemension] = "X";
                battlefield[iDemension - 3, jDemension] = "X";
            }
            else if(direction.Key == ConsoleKey.DownArrow)
            {
                battlefield[iDemension, jDemension] = "X";
                battlefield[iDemension + 1, jDemension] = "X";
                battlefield[iDemension + 2, jDemension] = "X";
                battlefield[iDemension + 3, jDemension] = "X";
            }

            Console.Clear();

            //формируем поле
            for (byte i = 0; i < battlefield.GetLength(0); i++)
            {
                if (i == 0)
                {
                    for (byte j = 1; j < battlefield.GetLength(1); j++)
                        battlefield[0, j] = (Convert.ToChar(j + 96)).ToString();
                    continue;
                }

                battlefield[i, 0] = i.ToString();
                for (byte j = 1; j < battlefield.GetLength(1); j++)
                {
                    if (battlefield[i, j] != "X")
                        battlefield[i, j] = "O";
                }
            }

            //выводим поле в консоль
            for (byte i = 0; i < battlefield.GetLength(0); i++)
            {
                for (byte j = 0; j < battlefield.GetLength(1); j++)
                {
                    string currCellVal = battlefield[i, j];
                    if (currCellVal == "X")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(String.Format("{0,-3}", currCellVal));
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    else
                    {
                        Console.Write(String.Format("{0,-3}", currCellVal));
                    } 
                }
                Console.WriteLine();
            }

            Console.WriteLine("Задайте начальную точку координат для первого крейсера («трёхпалубные»): ");
            userCoord = Console.ReadLine();
            Console.WriteLine("Выберите стрелкой направление размещения! ");
            direction = Console.ReadKey();
            //преобразовываем введенные координаты в координаты матрицы
            iDemension = Byte.Parse(userCoord[0].ToString());
            jDemension = Convert.ToByte(Convert.ToChar(userCoord[1]) - 96);

            if (direction.Key == ConsoleKey.LeftArrow)
            {
                battlefield[iDemension, jDemension] = "X";
                battlefield[iDemension, jDemension - 1] = "X";
                battlefield[iDemension, jDemension - 2] = "X";
            }
            else if (direction.Key == ConsoleKey.RightArrow)
            {
                battlefield[iDemension, jDemension] = "X";
                battlefield[iDemension, jDemension + 1] = "X";
                battlefield[iDemension, jDemension + 2] = "X";
            }
            else if (direction.Key == ConsoleKey.UpArrow)
            {
                battlefield[iDemension, jDemension] = "X";
                battlefield[iDemension - 1, jDemension] = "X";
                battlefield[iDemension - 2, jDemension] = "X";
            }
            else if (direction.Key == ConsoleKey.DownArrow)
            {
                battlefield[iDemension, jDemension] = "X";
                battlefield[iDemension + 1, jDemension] = "X";
                battlefield[iDemension + 2, jDemension] = "X";
            }

            Console.Clear();

            //формируем поле
            for (byte i = 0; i < battlefield.GetLength(0); i++)
            {
                if (i == 0)
                {
                    for (byte j = 1; j < battlefield.GetLength(1); j++)
                        battlefield[0, j] = (Convert.ToChar(j + 96)).ToString();
                    continue;
                }

                battlefield[i, 0] = i.ToString();
                for (byte j = 1; j < battlefield.GetLength(1); j++)
                {
                    if (battlefield[i, j] != "X")
                        battlefield[i, j] = "O";
                }
            }

            //выводим поле в консоль
            for (byte i = 0; i < battlefield.GetLength(0); i++)
            {
                for (byte j = 0; j < battlefield.GetLength(1); j++)
                {
                    string currCellVal = battlefield[i, j];
                    if (currCellVal == "X")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(String.Format("{0,-3}", currCellVal));
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    else
                    {
                        Console.Write(String.Format("{0,-3}", currCellVal));
                    }
                }
            }
            Console.WriteLine("Начало положено...");
        }

    }
}
