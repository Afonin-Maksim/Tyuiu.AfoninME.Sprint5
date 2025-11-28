using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.AfoninME.Sprint5.Task1.V29.Lib;

namespace Tyuiu.AfoninME.Sprint5.Task1.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            DataService ds = new DataService();

            int start = -5;
            int stop = 5;

            string path = ds.SaveToFileTextData(start, stop);

            // Проверка: после вызова метод должен создать файл
            bool fileExists = File.Exists(path);

            Assert.AreEqual(true, fileExists);
        }
    }
}