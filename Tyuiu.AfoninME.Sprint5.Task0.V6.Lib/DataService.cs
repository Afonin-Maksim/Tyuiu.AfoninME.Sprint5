using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.AfoninME.Sprint5.Task0.V6.Lib
{
    public class DataService : ISprint5Task0V6
    {
        public string SaveToFileTextData(int x)
        {

            string path = $@"{Path.GetTempFileName()}";

            double z = x / Math.Sqrt(x * x + x);

            z = Math.Round(z, 3);

            File.WriteAllText(path, Convert.ToString(z));
            return path;
        }
    }
}
