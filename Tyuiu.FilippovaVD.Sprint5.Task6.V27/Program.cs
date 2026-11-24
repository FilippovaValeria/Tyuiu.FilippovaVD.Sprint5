using System.IO;
using Tyuiu.FilippovaVD.Sprint5.Task6.V27.Lib;

namespace Tyuiu.FilippovaVD.Sprint5.Task6.V27
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Филиппова В. Д. | АСОиУб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Обработка текстовых файлов                                        *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #27                                                             *");
            Console.WriteLine("* Выполнил: Филиппова В. Д. | АСОиУб-26-1                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл C:\\DataSprint5\\InPutDataFileTask6V27.txt, в котором есть      *");
            Console.WriteLine("* набор символьных данных. Найти количество трехзначных чисел в заданной   *");
            Console.WriteLine("* строке.                                                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string pathToDisk = Path.Combine(@"C:\DataSprint5", "InPutDataFileTask6V27.txt");
            string pathToTemp = Path.Combine(Path.GetTempPath(), "InPutDataFileTask6V27.txt");

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
                Console.WriteLine("Создайте файл с текстом для проверки.");
                Console.ReadLine();
                return;
            }

            Console.WriteLine($"Путь к файлу: {currentPath}");
            Console.WriteLine($"Содержимое файла: {File.ReadAllText(currentPath)}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int result = ds.LoadFromDataFile(currentPath);

            Console.WriteLine($"Количество трехзначных чисел = {result}");

            Console.ReadLine();
        }
    }
}
