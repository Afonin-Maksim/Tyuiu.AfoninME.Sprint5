using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.AfoninME.Sprint5.Task7.V13.Lib
{
    public class DataService : ISprint5Task7V13
    {
        public string LoadDataAndSave(string path)
        {
            string text = File.ReadAllText(path);

            path = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V13.txt");

            if (File.Exists(path))
            {
                File.Delete(path);
            }

            File.WriteAllText(path, Regex.Replace(text, "[a-z]", ""));

            return path;
        }
    }
}