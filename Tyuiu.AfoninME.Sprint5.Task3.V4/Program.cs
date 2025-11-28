using System;
using System.IO;
using Tyuiu.AfoninME.Sprint5.Task3.V4.Lib;

internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #5 | Выполнил: Афонин М.Е. | ИСТНб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Потоковый метод записи данных в бинарный файл                     *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #4                                                              *");
        Console.WriteLine("* Выполнил: Афонин Максим Евгеньевич | ИСТНб-25-1                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Вычислить выражение y = ln((x + 1)/(x + 2)) при x = 3                   *");
        Console.WriteLine("* Результат округлить до 3 знаков и сохранить в бинарный файл.            *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int x = 3;
        Console.WriteLine("x = " + x);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        string path = ds.SaveToFileTextData(x);

        // Считываем результат из бинарного файла
        double result;
        using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
        {
            result = reader.ReadDouble();
        }

        Console.WriteLine($"Файл сохранён: {path}");
        Console.WriteLine($"y = {result}");

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Программа завершена                                                     *");
        Console.WriteLine("***************************************************************************");
        Console.ReadKey();
    }
}