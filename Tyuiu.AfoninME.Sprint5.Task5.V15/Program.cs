using System;
using System.IO;
using Tyuiu.AfoninME.Sprint5.Task5.V15.Lib;

namespace Tyuiu.AfoninME.Sprint5.Task5.V15
{
    internal class Program
    {
        static void Main()
        {
            Console.Title = "Спринт #5 | Выполнил: Афонин М.Е. | ИСТНб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Чтение данных из текстового файла. Анализ набора значений         *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил: Афонин Максим Евгеньевич | ИСТНб-25-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Прочитать набор чисел из файла C:\\DataSprint5\\InPutDataFileTask5V15.txt *");
            Console.WriteLine("* Найти минимальное число, которое делится на 5.                          *");
            Console.WriteLine("* Результат округлить до трёх знаков.                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            // путь к файлу
            string dir = @"C:\DataSprint5";
            string path = Path.Combine(dir, "InPutDataFileTask5V15.txt");

            if (!File.Exists(path))
            {
                Console.WriteLine("Файл не найден. Проверьте путь и наличие входного файла.");
                Console.WriteLine("***************************************************************************");
                Console.ReadKey();
                return;
            }

            DataService ds = new DataService();
            double result = ds.LoadFromDataFile(path);

            if (double.IsNaN(result))
            {
                Console.WriteLine("В файле нет чисел, которые делятся на 5.");
            }
            else
            {
                Console.WriteLine($"Минимальное число, делящееся на 5: {result}");
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Программа завершена                                                     *");
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}