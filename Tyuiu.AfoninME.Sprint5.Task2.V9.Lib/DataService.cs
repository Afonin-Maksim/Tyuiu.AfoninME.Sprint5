using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.AfoninME.Sprint5.Task2.V9.Lib
{
    public class DataService : ISprint5Task2V9
    {
        public string SaveToFileTextData(int[,] array)
        {
            // создаём путь во временной папке
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.csv");

            // если существует — удаляем, чтобы перезаписать
            if (File.Exists(path))
                File.Delete(path);

            int rows = array.GetLength(0);
            int cols = array.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                string line = "";
                for (int j = 0; j < cols; j++)
                {
                    int value = array[i, j];

                    // заменяем нечётные элементы на 0
                    if (value % 2 != 0)
                        value = 0;

                    // формируем csv-строку
                    line += value;
                    if (j < cols - 1)
                        line += ";";
                }

                if (i != rows - 1)
                    File.AppendAllText(path, line + Environment.NewLine);
                else
                    File.AppendAllText(path, line);
            }

            return path;
        }
    }
}