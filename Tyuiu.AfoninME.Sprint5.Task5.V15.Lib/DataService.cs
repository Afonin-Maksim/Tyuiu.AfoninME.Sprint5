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

            string fileContent = File.ReadAllText(path);
            char[] separators = { ' ', ',', '\t', '\n', '\r', ';' };
            string[] parts = fileContent.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            double min = double.MaxValue;
            bool found = false;

            foreach (var part in parts)
            {
                string normalized = part.Replace(',', '.');
                if (double.TryParse(normalized, NumberStyles.Float, CultureInfo.InvariantCulture, out double val))
                {
                    if (Math.Abs(val % 5) < 1e-9)
                    {
                        if (val < min)
                        {
                            min = val;
                            found = true;
                        }
                    }
                }
            }

            return found ? Math.Round(min, 3) : double.NaN;
        }
    }
}