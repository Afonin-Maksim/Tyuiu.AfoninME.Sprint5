using System;
using System.Globalization;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.AfoninME.Sprint5.Task4.V14.Lib
{
    public class DataService : ISprint5Task4V14
    {
        public double LoadFromDataFile(string path)
        {
            // Читаем строку из файла
            string textFromFile = File.ReadAllText(path).Trim();

            // Преобразуем число независимо от локали
            double x = Convert.ToDouble(textFromFile, CultureInfo.InvariantCulture);

            if (Math.Abs(x) < 1e-9)
                throw new DivideByZeroException("x не может быть равен 0 в выражении 2/x.");

            double y = Math.Sin(Math.Pow(x, 3)) + 2 / x;
            return Math.Round(y, 3);
        }
    }
}