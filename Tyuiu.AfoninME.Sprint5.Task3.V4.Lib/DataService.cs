using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.AfoninME.Sprint5.Task3.V4.Lib
{
    public class DataService : ISprint5Task3V4
    {
        public string SaveToFileTextData(int x)
        {
            // Путь файла в системной директории Temp
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");

            // Вычисляем значение выражения
            double y = Math.Log((x + 1.0) / (x + 2.0));
            y = Math.Round(y, 3);

            // Запись в бинарный файл
            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.Create)))
            {
                writer.Write(y);
            }

            return path;
        }
    }
}