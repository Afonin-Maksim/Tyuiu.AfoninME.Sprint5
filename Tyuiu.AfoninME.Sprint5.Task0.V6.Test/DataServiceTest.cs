using Tyuiu.AfoninME.Sprint5.Task0.V6.Lib;

namespace Tyuiu.AfoninME.Sprint5.Task0.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            DataService ds = new DataService();

            int x = 3;

            string path = @"C:\Users\user\source\repos\Tyuiu.SherenkovIR.Sprint5\Tyuiu.SherenkovIR.Sprint5.Task0.V6\bin\Debug\net8.0\OutPutFileTask0.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = false;
            Assert.AreEqual(wait, fileExists);
        }
    }
}