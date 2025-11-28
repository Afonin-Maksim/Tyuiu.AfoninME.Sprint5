using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.AfoninME.Sprint5.Task1.V29.Lib
{
    public class DataService : ISprint5Task1V29
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask1.txt";
            FileInfo fileInfo = new FileInfo(path);

            // Если файл существует — удаляем, чтобы создать заново
            if (fileInfo.Exists)
            {
                File.Delete(path);
            }

            for (int x = startValue; x <= stopValue; x++)
            {
                double y;

                // Проверка деления на ноль при (x + 1.2) == 0
                if (Math.Abs(x + 1.2) < 1e-7)
                {
                    y = 0;
                }
                else
                {
                    y = (Math.Sin(x) / (x + 1.2)) + (Math.Cos(x) * 7 * x) - 2;
                    y = Math.Round(y, 2);
                }

                // Формируем строку для записи
                string str = y.ToString();

                // Записываем построчно (последняя строка без новой строки)
                if (x != stopValue)
                {
                    File.AppendAllText(path, str + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, str);
                }
            }

            // Возвращаем путь к созданному файлу
            return path;
        }
    }
}