using System;
using System.Globalization;
using System.IO;
using System.Linq;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.AfoninME.Sprint5.Task5.V15.Lib
{
    public class DataService : ISprint5Task5V15
    {
        public double LoadFromDataFile(string path)
        {
            string[] lines = File.ReadAllLines(path);

            double min = double.MaxValue;
            bool found = false;

            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                // Универсальное преобразование (точка и запятая)
                double value = Convert.ToDouble(line.Trim().Replace(",", "."), CultureInfo.InvariantCulture);

                if (Math.Abs(value % 5) < 1e-9)
                {
                    if (value < min)
                    {
                        min = value;
                        found = true;
                    }
                }
            }

            if (!found)
                return double.NaN;

            return Math.Round(min, 3);
        }
    }
}