using System.IO;
using Tyuiu.FilippovaVD.Sprint5.Task0.V7.Lib;

namespace Tyuiu.FilippovaVD.Sprint5.Task0.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Филиппова В. Д. | АСОиУб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись данных в текстовый файл                        *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнил: Филиппова В. Д. | АСОиУб-26-1                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дано выражение F(x) = -x^3 + 4x^2 - (3/2)x. Вычислить его значение при  *");
            Console.WriteLine("* x = 4, результат сохранить в текстовый файл OutPutFileTask0.txt и       *");
            Console.WriteLine("* вывести на консоль. Округлить до трёх знаков после запятой.             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x = 4;
            Console.WriteLine($"x = {x}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string path = ds.SaveToFileTextData(x);

            string fileContent = File.ReadAllText(path);

            Console.WriteLine($"Значение выражения F({x}) = {fileContent}");
            Console.WriteLine($"Файл сохранен по пути: {path}");

            Console.ReadLine();
        }
    }
}
