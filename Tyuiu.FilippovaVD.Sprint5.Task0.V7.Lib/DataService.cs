using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.FilippovaVD.Sprint5.Task0.V7.Lib
{
    public class DataService : ISprint5Task0V7
    {
        public string SaveToFileTextData(int x)
        {
            double result = -Math.Pow(x, 3) + 4 * Math.Pow(x, 2) - (3.0 / 2.0) * x;

            result = Math.Round(result, 3);

            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");

            File.WriteAllText(path, result.ToString());

            return path;
        }
    }
}