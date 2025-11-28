using System;
using System.IO;
using Tyuiu.AfoninME.Sprint5.Task5.V15.Lib;

internal class Program
{
    static void Main()
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #5 | Выполнил Куприянов Е. А. | АСОиУб-23-2";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Обработка файлов                                                  *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #15                                                             *");
        Console.WriteLine("* Выполнил: Куприянов Евгений Александрович | АСОиУб-23-2                 *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу на C#, Дан файл в котором есть набор значений. Найти *");
        Console.WriteLine("* минимальное вещественное число в файле, которое делится на 5.           *");
        Console.WriteLine("* Полученный результат вывести на консоль. У вещественных значений        *");
        Console.WriteLine("* округлить до трёх знаков после запятой.                                 *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        string path = $@"{Directory.GetCurrentDirectory()}\InPutDataFileTask5V15.txt";

        Console.WriteLine("Данные находятся в файле: " + path);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        double res = ds.LoadFromDataFile(path);

        Console.WriteLine("Минимальное вещественное число, которое делится на 5 = " + res);
        Console.ReadKey();
    }
}