using System;
using Tyuiu.AfoninME.Sprint5.Task2.V9.Lib;

internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #5 | Выполнил: Афонин М.Е. | ИСТНб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Класс File. Запись структурированных данных в текстовый файл      *");
        Console.WriteLine("* Задание #2                                                              *");
        Console.WriteLine("* Вариант #9                                                              *");
        Console.WriteLine("* Выполнил: Афонин Максим Евгеньевич | ИСТНб-25-1                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан двумерный массив 3x3, элементы вводятся с клавиатуры.               *");
        Console.WriteLine("* Все нечётные элементы массива заменить на 0.                            *");
        Console.WriteLine("* Результат сохранить в файл OutPutFileTask2.csv и вывести на консоль.    *");
        Console.WriteLine("***************************************************************************");

        int[,] matrix = new int[3, 3];

        Console.WriteLine("Введите элементы массива 3x3:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"matrix[{i},{j}] = ");
                matrix[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        string path = ds.SaveToFileTextData(matrix);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine($"Файл сохранён: {path}");
        Console.WriteLine();

        string[] lines = File.ReadAllLines(path);
        foreach (var line in lines)
        {
            Console.WriteLine(line);
        }

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Программа завершена                                                     *");
        Console.WriteLine("***************************************************************************");

        Console.ReadKey();
    }
}