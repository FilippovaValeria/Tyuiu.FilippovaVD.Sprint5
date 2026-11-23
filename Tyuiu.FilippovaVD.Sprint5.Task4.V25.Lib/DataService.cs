using System.IO;
using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.FilippovaVD.Sprint5.Task4.V25.Lib
{
    public class DataService : ISprint5Task4V25
    {
        public double LoadFromDataFile(string path)
        {
            string fileContent = File.ReadAllText(path);

            double x = Convert.ToDouble(fileContent, CultureInfo.InvariantCulture);

            double result = (Math.Pow(x, 4) + Math.Cos(x)) * Math.Sin(x);

            result = Math.Round(result, 3);

            return result;
        }
    }
}
