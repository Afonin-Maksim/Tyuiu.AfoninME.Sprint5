using System;
using System.IO;
using Tyuiu.AfoninME.Sprint5.Task4.V14.Lib;

internal class Program
{
    static void Main()
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #5 | Выполнил: Афонин М.Е. | ИСТНб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Чтение данных из текстового файла                                 *");
        Console.WriteLine("* Задание #4                                                              *");
        Console.WriteLine("* Вариант #14                                                             *");
        Console.WriteLine("* Выполнил: Афонин Максим Евгеньевич | ИСТНб-25-1                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан файл C:\\DataSprint5\\InPutDataFileTask4V0.txt, содержащий число X. *");
        Console.WriteLine("* Прочитать значение X из файла и вычислить по формуле                    *");
        Console.WriteLine("* y = sin(x^3) + 2/x                                                      *");
        Console.WriteLine("* Округлить результат до трёх знаков после запятой.                       *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        string path = @"C:\DataSprint5\InPutDataFileTask4V0.txt";

        if (!File.Exists(path))
        {
            Console.WriteLine("Файл не найден. Проверьте, что он расположен по пути:");
            Console.WriteLine(path);
            return;
        }

        double result = ds.LoadFromDataFile(path);

        Console.WriteLine($"Результат вычисления: y = {result}");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Программа завершена                                                     *");
        Console.WriteLine("***************************************************************************");

        Console.ReadKey();
    }
}