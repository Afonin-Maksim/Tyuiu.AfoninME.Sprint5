using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.AfoninME.Sprint5.Task3.V4.Lib;

namespace Tyuiu.AfoninME.Sprint5.Task3.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            DataService ds = new DataService();

            int x = 3;
            string path = ds.SaveToFileTextData(x);

            bool fileExists = File.Exists(path);
            Assert.AreEqual(true, fileExists);

            // Проверим корректность записанного значения
            double result;
            using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                result = reader.ReadDouble();
            }

            double expected = Math.Round(Math.Log((x + 1.0) / (x + 2.0)), 3);
            Assert.AreEqual(expected, result, 0.0001);
        }
    }
}