using System.IO;
using Tyuiu.FilippovaVD.Sprint5.Task7.V22.Lib;

namespace Tyuiu.FilippovaVD.Sprint5.Task7.V22
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Филиппова В. Д. | АСОиУб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #22                                                             *");
            Console.WriteLine("* Выполнил: Филиппова В. Д. | АСОиУб-26-1                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл C:\\DataSprint5\\InPutDataFileTask7V22.txt. Заменить все знаки   *");
            Console.WriteLine("* препинания на #. Результат сохранить в OutPutDataFileTask7V22.txt.      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string pathToDisk = Path.Combine(@"C:\DataSprint5", "InPutDataFileTask7V22.txt");
            string pathToTemp = Path.Combine(Path.GetTempPath(), "InPutDataFileTask7V22.txt");

            string currentPath = "";

            if (File.Exists(pathToDisk))
            {
                currentPath = pathToDisk;
            }
            else if (File.Exists(pathToTemp))
            {
                currentPath = pathToTemp;
            }
            else
            {
                Console.WriteLine("ОШИБКА: Файл не найден ни по пути C:\\DataSprint5, ни в Temp папке!");
                Console.WriteLine("Создайте файл с текстом для проверки (например, C:\\DataSprint5\\InPutDataFileTask7V22.txt).");
                Console.ReadLine();
                return;
            }

            Console.WriteLine($"Путь к исходному файлу: {currentPath}");
            Console.WriteLine($"Исходный текст: {File.ReadAllText(currentPath)}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string outPath = ds.LoadDataAndSave(currentPath);

            Console.WriteLine($"Файл сохранен: {outPath}");
            Console.WriteLine($"Измененный текст: {File.ReadAllText(outPath)}");

            Console.ReadLine();
        }
    }
}
