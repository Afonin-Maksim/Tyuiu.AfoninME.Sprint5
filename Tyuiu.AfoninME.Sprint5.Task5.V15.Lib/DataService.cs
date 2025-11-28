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
            if (!File.Exists(path))
                throw new FileNotFoundException("Файл не найден.", path);

            double? min = null;

            using (StreamReader sr = new StreamReader(path))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    if (string.IsNullOrWhiteSpace(line)) continue;

                    string[] parts = line.Split(new char[] { ' ', '\t', ';' }, StringSplitOptions.RemoveEmptyEntries);

                    foreach (string s in parts)
                    {
                        if (double.TryParse(s, NumberStyles.Float, CultureInfo.InvariantCulture, out double value))
                        {
                            // Проверяем: число положительное и делится на 5
                            if (value > 0 && Math.Abs(value % 5) < 1e-9)
                            {
                                if (!min.HasValue || value < min.Value)
                                    min = value;
                            }
                        }
                    }
                }
            }

            return min.HasValue ? Math.Round(min.Value, 3) : double.NaN;
        }
    }
}