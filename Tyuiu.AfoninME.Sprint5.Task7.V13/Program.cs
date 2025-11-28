using System;
using System.IO;
using Tyuiu.AfoninME.Sprint5.Task7.V13.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #5 | Выполнил: Афонин М.Е. | ИСТНб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #13                                                             *");
        Console.WriteLine("* Выполнил: Афонин М.Е. | ИСТНб-25-1                                      *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан файл, содержащий набор символов. Удалить из него все строчные       *");
        Console.WriteLine("* латинские буквы и сохранить результат в новый файл.                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        string path = @"C:\DataSprint5\InPutDataFileTask7V13.txt";
        Console.WriteLine("Данные находятся в файле: " + path);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        try
        {
            string resultPath = ds.LoadDataAndSave(path);
            Console.WriteLine("Результат успешно сохранён в файл:");
            Console.WriteLine(resultPath);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ошибка: " + ex.Message);
        }

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Работа программы завершена.");
        Console.ReadKey();
    }
}