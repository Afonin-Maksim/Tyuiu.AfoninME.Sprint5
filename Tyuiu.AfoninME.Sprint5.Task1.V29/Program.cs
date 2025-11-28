using System;
using System.IO;
using Tyuiu.AfoninME.Sprint5.Task1.V29.Lib;

internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #5 | Выполнил: Афонин М.Е. | ИСТНб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                 *");
        Console.WriteLine("* Задание #1                                                              *");
        Console.WriteLine("* Вариант #29                                                             *");
        Console.WriteLine("* Выполнил: Афонин Максим Евгеньевич | ИСТНб-25-1                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дана функция:                                                           *");
        Console.WriteLine("* F(x) = sin(x)/(x+1.2) + cos(x)*7x - 2                                   *");
        Console.WriteLine("* Выполнить табулирование f(x) на промежутке [-5;5] с шагом 1.           *");
        Console.WriteLine("* При делении на ноль вернуть значение 0.                                 *");
        Console.WriteLine("* Сохранить результат в текстовый файл OutPutFileTask1.txt.               *");
        Console.WriteLine("* Округлить значения до двух знаков после запятой.                        *");
        Console.WriteLine("***************************************************************************");

        int startValue = -5;
        int stopValue = 5;

        string path = ds.SaveToFileTextData(startValue, stopValue);

        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine($"Файл сохранён: {path}");
        Console.WriteLine();

        // Считываем файл и выводим построчно
        string[] lines = File.ReadAllLines(path);
        Console.WriteLine("   x\t|\tF(x)");
        Console.WriteLine("-----------|-----------");

        int x = startValue;
        foreach (string line in lines)
        {
            Console.WriteLine($"{x,5}\t|\t{line,7}");
            x++;
        }

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Программа завершена                                                     *");
        Console.WriteLine("***************************************************************************");

        Console.ReadKey();
    }
}