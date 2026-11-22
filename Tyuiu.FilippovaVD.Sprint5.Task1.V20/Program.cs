using System.IO;
using Tyuiu.FilippovaVD.Sprint5.Task1.V20.Lib;

namespace Tyuiu.FilippovaVD.Sprint5.Task1.V20
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Филиппова В. Д. | АСОиУб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                 *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #20                                                             *");
            Console.WriteLine("* Выполнил: Филиппова В. Д. | АСОиУб-26-1                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана функция F(x). Произвести табулирование f(x) на заданном диапазоне  *");
            Console.WriteLine("* [-5; 5] с шагом 1. Произвести проверку деления на ноль. При делении на  *");
            Console.WriteLine("* ноль вернуть значение 0. Результат сохранить в текстовый файл           *");
            Console.WriteLine("* OutPutFileTask1.txt и вывести на консоль в таблицу.                     *");
            Console.WriteLine("* Значения округлить до двух знаков после запятой.                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;
            Console.WriteLine($"Диапазон: от {startValue} до {stopValue}, шаг: 1");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string path = ds.SaveToFileTextData(startValue, stopValue);
            Console.WriteLine($"Файл сохранен: {path}");
            Console.WriteLine();

            string[] lines = File.ReadAllLines(path);

            Console.WriteLine("+----------+----------+");
            Console.WriteLine("|    X     |   F(X)   |");
            Console.WriteLine("+----------+----------+");

            int currentX = startValue; 
            foreach (string line in lines)
            {
                Console.WriteLine($"| {currentX,-8} | {line,-8} |");
                currentX++;
            }
            Console.WriteLine("+----------+----------+");

            Console.ReadLine();
        }
    }
}
