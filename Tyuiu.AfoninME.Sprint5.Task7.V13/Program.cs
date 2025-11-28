using System.Text;
using Tyuiu.AfoninME.Sprint5.Task7.V13.Lib;

Console.OutputEncoding = Encoding.UTF8;

Console.Title = "Спринт #5 | Выполнил: Зятьков Д. В. | ПИНб-25-1";
Console.WriteLine(new string('*', 75));
Console.WriteLine("* Спринт #5                                                               *");
Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
Console.WriteLine("* Задание #7                                                              *");
Console.WriteLine("* Вариант #13                                                             *");
Console.WriteLine("* Выполнил: Зятьков Дмитрий Владимирович | ПИНб-25-1                      *");
Console.WriteLine(new string('*', 75));
Console.WriteLine("* УСЛОВИЕ: Дан файл С:\\DataSprint5\\InPutDataFileTask7V13.txt, в котором   *");
Console.WriteLine("* есть набор символьных данных.Удалить все строчные латинские буквы из    *");
Console.WriteLine("* файла. Полученный результат сохранить в файл OutPutDataFileTask7V13.txt *");
Console.WriteLine(new string('*', 75));
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine(new string('*', 75));

var result = new DataService();

string x = "C:\\DataSprint5\\InPutDataFileTask7V13.txt";

Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine(result.LoadDataAndSave(x).ToString());

Console.WriteLine(File.ReadAllText($@"{Path.GetTempPath()}\OutPutDataFileTask7V13.txt"));

Console.WriteLine(new string('*', 75));
Console.ReadKey();