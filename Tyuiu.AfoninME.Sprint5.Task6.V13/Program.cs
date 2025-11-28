using System;
using System.IO;
using Tyuiu.AfoninME.Sprint5.Task6.V13.Lib;

namespace Tyuiu.AfoninME.Sprint5.Task6.V13
{
    internal class Program
    {
        static void Main()
        {
            Console.Title = "Спринт #5 | Афонин М.Е. | ИСТНб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Обработка текстовых файлов                                        *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнил: Афонин Максим Евгеньевич | ИСТНб-25-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл C:\\DataSprint5\\InPutDataFileTask6V13.txt                      *");
            Console.WriteLine("* Требуется найти количество удвоенных букв 'cc' в тексте.                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask6V13.txt";

            if (!File.Exists(path))
            {
                Console.WriteLine("Ошибка: входной файл не найден. Проверьте путь и наличие файла.");
                Console.ReadKey();
                return;
            }

            DataService ds = new DataService();
            int result = ds.LoadFromDataFile(path);

            Console.WriteLine($"Количество удвоенных букв 'cc' в тексте: {result}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Программа завершена                                                     *");
            Console.WriteLine("***************************************************************************");

            Console.ReadKey();
        }
    }
}