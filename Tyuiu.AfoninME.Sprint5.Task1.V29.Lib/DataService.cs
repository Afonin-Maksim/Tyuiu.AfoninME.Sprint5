using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.AfoninME.Sprint5.Task1.V29.Lib
{
    public class DataService : ISprint5Task1V29
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            // Создание файла в папке Temp
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");

            if (File.Exists(path)) File.Delete(path);

            for (int x = startValue; x <= stopValue; x++)
            {
                double y;

                if (Math.Abs(x + 1.2) < 1e-8)
                {
                    y = 0;
                }
                else
                {
                    y = Math.Sin(x) / (x + 1.2) + Math.Cos(x) * 7 * x - 2;
                    y = Math.Round(y, 2);
                }

                string str = y.ToString();

                if (x != stopValue)
                    File.AppendAllText(path, str + Environment.NewLine);
                else
                    File.AppendAllText(path, str);
            }

            return path;
        }
    }
}