using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.AfoninME.Sprint5.Task6.V13.Lib;

namespace Tyuiu.AfoninME.Sprint5.Task6.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CountDoubleCC()
        {
            DataService ds = new DataService();

            string dir = Path.GetTempPath();
            string path = Path.Combine(dir, "InPutDataFileTask6V13.txt");

            // В тексте 2×"cc": => Lexington и accessory
            File.WriteAllText(path, "access code cccorner");

            int result = ds.LoadFromDataFile(path);

            // Проверим: "access" (1×) + "ccc" (2× пересекающиеся) = 3
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void NoDoubleCC()
        {
            DataService ds = new DataService();
            string path = Path.GetTempFileName();
            File.WriteAllText(path, "abcx yza");
            int result = ds.LoadFromDataFile(path);
            Assert.AreEqual(0, result);
        }
    }
}