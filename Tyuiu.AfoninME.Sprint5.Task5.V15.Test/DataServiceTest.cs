using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.AfoninME.Sprint5.Task5.V15.Lib;

namespace Tyuiu.AfoninME.Sprint5.Task5.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            DataService ds = new DataService();

            string dir = @"C:\DataSprint5";
            string path = Path.Combine(dir, "InPutDataFileTask5V15.txt");

            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);

            // подготовим набор: 12.5, 5, 30, 1, 9
            File.WriteAllLines(path, new string[] { "12.5", "5", "30", "1", "9" });

            double result = ds.LoadFromDataFile(path);

            // Числа, делящиеся на 5 → 12.5, 5, 30 → минимальное 5
            Assert.AreEqual(5, result);
        }
    }
}