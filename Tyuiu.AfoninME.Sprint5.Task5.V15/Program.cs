using System;
using System.IO;
using Tyuiu.AfoninME.Sprint5.Task5.V15.Lib;

namespace Tyuiu.AfoninME.Sprint5.Task5.V15
{
    internal class Program
    {
        static void Main()
        {
            Console.Title = "Спринт #5 | Афонин М.Е. | ИСТНб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5 | Тема: Чтение данных из текстового файла                     *");
            Console.WriteLine("* Задание #5 | Вариант #15                                                *");
            Console.WriteLine("* Выполнил: Афонин Максим Евгеньевич | ИСТНб-25-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Прочитать набор чисел из файла C:\\DataSprint5\\InPutDataFileTask5V15.txt *");
            Console.WriteLine("* Найти минимальное положительное число, которое делится на 5.            *");
            Console.WriteLine("* Результат округлить до трёх знаков.                                     *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask5V15.txt";

            if (!File.Exists(path))
            {
                Console.WriteLine("Файл не найден. Проверьте путь к входному файлу.");
                Console.ReadKey();
                return;
            }

            DataService ds = new DataService();
            double result = ds.LoadFromDataFile(path);

            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            if (double.IsNaN(result))
                Console.WriteLine("Подходящих чисел не найдено.");
            else
                Console.WriteLine($"Минимальное положительное число, делящееся на 5: {result}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Программа завершена                                                     *");
            Console.WriteLine("***************************************************************************");

            Console.ReadKey();
        }
    }
}