using System.IO;
using Tyuiu.FilippovaVD.Sprint5.Task4.V25.Lib;

namespace Tyuiu.FilippovaVD.Sprint5.Task4.V25
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Филиппова В. Д. | АСОиУб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Чтение данных из текстового файла                                 *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #25                                                             *");
            Console.WriteLine("* Выполнил: Филиппова В. Д. | АСОиУб-26-1                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл C:\\DataSprint5\\InPutDataFileTask4V0.txt, в котором есть       *");
            Console.WriteLine("* вещественное значение. Прочитать значение из файла и подставить вместо  *");
            Console.WriteLine("* X в формуле y = (x^4 + cos(x)) * sin(x). Округлить до 3 знаков.         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string pathToDisk = Path.Combine(@"C:\DataSprint5", "InPutDataFileTask4V0.txt");
            string pathToTemp = Path.Combine(Path.GetTempPath(), "InPutDataFileTask4V0.txt");

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
                Console.ReadLine();
                return;
            }

            Console.WriteLine($"Путь к файлу: {currentPath}");
            string xValue = File.ReadAllText(currentPath);
            Console.WriteLine($"Считанное значение X: {xValue}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double result = ds.LoadFromDataFile(currentPath);

            Console.WriteLine($"Значение функции y = {result}");

            Console.ReadLine();
        }
    }
}
