using System.IO;
using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.FilippovaVD.Sprint5.Task1.V20.Lib
{
    public class DataService : ISprint5Task1V20
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");
            File.WriteAllText(path, ""); 

            for (int x = startValue; x <= stopValue; x++)
            {
                double result = 0;
                double denominator = Math.Sin(x) + 3;

                if (denominator != 0)
                {
                    result = (5.0 * x + 2.5) / denominator + 2.0 * x + Math.Cos(x);
                    result = Math.Round(result, 2);
                }

                string line = result.ToString("F2", new CultureInfo("ru-RU"));

                line = line.TrimEnd('0');
                if (line.EndsWith(","))
                {
                    line = line.TrimEnd(',');
                }

                File.AppendAllText(path, line + Environment.NewLine);
            }

            return path;
        }
    }
}
