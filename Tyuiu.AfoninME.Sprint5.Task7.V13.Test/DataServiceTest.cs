using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.AfoninME.Sprint5.Task7.V13.Lib;

namespace Tyuiu.AfoninME.Sprint5.Task7.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedCreateOutputFile()
        {
            string tempDir = Path.GetTempPath();
            string inputPath = Path.Combine(tempDir, "InPutDataFileTask7V13.txt");
            File.WriteAllText(inputPath, "AbCdEfG123xYz");
            DataService ds = new DataService();
            string outputPath = ds.LoadDataAndSave(inputPath);
            bool fileExists = File.Exists(outputPath);
            Assert.IsTrue(fileExists);
        }
    }
}