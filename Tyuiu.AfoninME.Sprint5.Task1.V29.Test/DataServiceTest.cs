using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.AfoninME.Sprint5.Task1.V29.Lib;

namespace Tyuiu.AfoninME.Sprint5.Task1.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            DataService ds = new DataService();

            // вызываем метод, который сам создаёт файл и вернёт его путь
            string filePath = ds.SaveToFileTextData(-5, 5);

            // проверяем, что такой файл теперь существует
            bool fileExists = File.Exists(filePath);

            Assert.AreEqual(true, fileExists);
        }
    }
}