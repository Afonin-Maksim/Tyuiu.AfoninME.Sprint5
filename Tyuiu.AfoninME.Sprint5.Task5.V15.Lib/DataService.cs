using System;
using System.Globalization;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.AfoninME.Sprint5.Task5.V15.Lib
{
    public class DataService : ISprint5Task5V15
    {
        public double LoadFromDataFile(string path)
        {
            // Читаем весь файл одной строкой
            string fileContent = File.ReadAllText(path);

            // Разбиваем по пробелам, табам, переводам строк и точкам с запятой
            char[] separators = { ' ', '\t', '\n', '\r', ';' };
            string[] parts = fileContent.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            double min = double.MaxValue;
            bool found = false;

            foreach (string part in parts)
            {
                // Нормализуем разделитель десятичной точки
                string normalized = part.Replace(',', '.');

                // Пробуем преобразовать каждое значение
                if (double.TryParse(normalized, NumberStyles.Float, CultureInfo.InvariantCulture, out double value))
                {
                    // Проверяем деление на 5
                    if (Math.Abs(value % 5) < 1e-9)
                    {
                        if (value < min)
                        {
                            min = value;
                            found = true;
                        }
                    }
                }
            }

            return found ? Math.Round(min, 3) : double.NaN;
        }
    }
}