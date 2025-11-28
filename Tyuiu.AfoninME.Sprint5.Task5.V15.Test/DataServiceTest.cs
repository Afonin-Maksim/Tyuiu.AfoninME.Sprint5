using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.AfoninME.Sprint5.Task5.V15.Lib;

namespace Tyuiu.AfoninME.Sprint5.Task5.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void FindPositiveMinDivisibleBy5()
        {
            DataService ds = new DataService();
            string dir = Path.GetTempPath();
            string path = Path.Combine(dir, "InPutDataFileTask5V15.txt");

            // Набор: включает отрицательное -5 (игнорируется),
            // положительное 10 (должно быть выбрано)
            File.WriteAllLines(path, new string[]
            {
                "-5", "15", "10", "25", "30", "2", "3"
            });

            double result = ds.LoadFromDataFile(path);

            // Ожидаем 10 (минимальное положительное, кратное 5)
            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void NoDivisibleByFive()
        {
            DataService ds = new DataService();
            string path = Path.GetTempFileName();
            File.WriteAllLines(path, new string[] { "1", "2", "3", "4" });
            Assert.IsTrue(double.IsNaN(ds.LoadFromDataFile(path)));
        }
    }
}