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
            // Arrange
            DataService ds = new DataService();

            string dir = Path.GetTempPath();
            string path = Path.Combine(dir, "InPutDataFileTask5V15.txt");

            File.WriteAllLines(path, new string[] { "12.5", "5", "30", "1", "9" });

            // Act
            double result = ds.LoadFromDataFile(path);

            // Assert
            // Числа, делящиеся на 5: 12.5, 5, 30 → минимальное = 5
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void NoDivisibleByFive()
        {
            DataService ds = new DataService();

            string path = Path.GetTempFileName();
            File.WriteAllLines(path, new string[] { "1", "2", "3", "4" });

            double result = ds.LoadFromDataFile(path);
            Assert.IsTrue(double.IsNaN(result));
        }
    }
}