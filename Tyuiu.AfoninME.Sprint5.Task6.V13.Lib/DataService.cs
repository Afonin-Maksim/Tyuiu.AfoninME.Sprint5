using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.AfoninME.Sprint5.Task6.V13.Lib
{
    public class DataService : ISprint5Task6V13
    {
        public int LoadFromDataFile(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException("Файл не найден.", path);

            string text = File.ReadAllText(path);

            int count = 0;
            for (int i = 0; i < text.Length - 1; i++)
            {
                if (text[i] == 'c' && text[i + 1] == 'c') count++;
            }

            return count;
        }
    }
}