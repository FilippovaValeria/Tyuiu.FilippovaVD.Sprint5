using System.IO;
using Tyuiu.FilippovaVD.Sprint5.Task5.V19.Lib;

namespace Tyuiu.FilippovaVD.Sprint5.Task5.V19
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Филиппова В. Д. | АСОиУб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Чтение набора данных из текстового файла                          *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #19                                                             *");
            Console.WriteLine("* Выполнил: Филиппова В. Д. | АСОиУб-26-1                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл C:\\DataSprint5\\InPutDataFileTask5V19.txt, в котором есть      *");
            Console.WriteLine("* набор значений. Найти разницу между максимальным и минимальным          *");
            Console.WriteLine("* однозначными целыми числами в файле.                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string pathToDisk = Path.Combine(@"C:\DataSprint5", "InPutDataFileTask5V19.txt");
            string pathToTemp = Path.Combine(Path.GetTempPath(), "InPutDataFileTask5V19.txt");

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
                Console.WriteLine("Создайте файл с числами для проверки.");
                Console.ReadLine();
                return;
            }

            Console.WriteLine($"Путь к файлу: {currentPath}");
            Console.WriteLine($"Содержимое файла: {File.ReadAllText(currentPath)}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double result = ds.LoadFromDataFile(currentPath);

            Console.WriteLine($"Разница между максимальным и минимальным однозначными числами = {result}");

            Console.ReadLine();
        }
    }
}
