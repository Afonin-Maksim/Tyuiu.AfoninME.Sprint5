using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.AfoninME.Sprint5.Task4.V14.Lib;

namespace Tyuiu.AfoninME.Sprint5.Task4.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            DataService ds = new DataService();

            // Подготовка файла
            string dir = @"C:\DataSprint5";
            string path = Path.Combine(dir, "InPutDataFileTask4V0.txt");

            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);

            File.WriteAllText(path, "3.0");  // Используем точку!

            double result = ds.LoadFromDataFile(path);
            double expected = Math.Round(Math.Sin(Math.Pow(3.0, 3)) + 2.0 / 3.0, 3);

            Assert.AreEqual(expected, result, 0.0001);
        }
    }
}