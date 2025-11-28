using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.AfoninME.Sprint5.Task7.V13.Lib
{
    public class DataService : ISprint5Task7V13
    {
        public string LoadDataAndSave(string path)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException("Файл не найден!", path);
            }
            string pathSaveFile = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V13.txt");
            if (File.Exists(pathSaveFile))
            {
                File.Delete(pathSaveFile);
            }
            using (StreamReader reader = new StreamReader(path))
            {
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    string filteredLine = "";
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (!(line[i] >= 'a' && line[i] <= 'z'))
                        {
                            filteredLine += line[i];
                        }
                    }
                    File.AppendAllText(pathSaveFile, filteredLine + Environment.NewLine);
                }
            }

            return pathSaveFile;
        }
    }
}