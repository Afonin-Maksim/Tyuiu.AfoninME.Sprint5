using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.AfoninME.Sprint5.Task2.V9.Lib;

namespace Tyuiu.AfoninME.Sprint5.Task2.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            DataService ds = new DataService();

            int[,] mtrx = new int[3, 3]
            {
                {6, 8, 3},
                {2, 6, 8},
                {1, 7, 1}
            };

            string path = ds.SaveToFileTextData(mtrx);
            bool fileExists = File.Exists(path);

            Assert.AreEqual(true, fileExists);
        }
    }
}