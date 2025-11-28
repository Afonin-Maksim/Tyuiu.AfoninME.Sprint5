using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.AfoninME.Sprint5.Task1.V29.Lib;
namespace Tyuiu.AfoninME.Sprint5.Task1.V29
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Афонин М.Е. | ИСТНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #29                                                             *");
            Console.WriteLine("* Выполнил: Афонин М.Е. | ИСТНб-25-1                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая производит табулирование функции:           *");
            Console.WriteLine("* F(x) = (sin(x) / (x + 1,2)) + cos(x) * 7 * x - 2 на заданном диапазоне  *");
            Console.WriteLine("* [-5; 5] с шагом 1. Произвести проверку деления на на ноль. При делении  *");
            Console.WriteLine("* на ноль вернуть значение 0. Результат сохранить в текстовый файл        *");
            Console.WriteLine("* OutPutFileTask0.txt и вывести на консоль в таблицу.                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double y;
            int startValue = -5;
            int stopValue = 5;
            Console.WriteLine("startValue = " + startValue);
            Console.WriteLine("stopValue = " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("+-----------+-----------+");
            Console.WriteLine("|     x     |    f(x)   |");
            Console.WriteLine("+-----------+-----------+");

            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Round(((Math.Sin(x) / (x + 1.2)) + Math.Cos(x) * 7 * x - 2), 2);
                if ((x + 1.2) == 0)
                {
                    y = 0;
                    Console.WriteLine("| {0,5:d}     |  {1, 6:f2}   |", x, y);
                }
                else
                {
                    Console.WriteLine("| {0,5:d}     |  {1, 6:f2}   |", x, y);
                }
            }

            Console.WriteLine("+-----------+-----------+");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(startValue, stopValue);
            Console.WriteLine("Фaйл: " + res);
            Console.WriteLine("Coздан!");
            Console.ReadKey();
        }
    }
}