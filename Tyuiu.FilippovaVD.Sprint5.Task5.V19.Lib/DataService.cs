using System.IO;
using System.Globalization;
using System.Collections.Generic;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.FilippovaVD.Sprint5.Task5.V19.Lib
{
    public class DataService : ISprint5Task5V19
    {
        public double LoadFromDataFile(string path)
        {
            string fileContent = File.ReadAllText(path);
            string[] stringNumbers = fileContent.Split(new char[] { ' ', '\n', '\n', '\r', ';' }, StringSplitOptions.RemoveEmptyEntries);

            List<int> singleDigitNumbers = new List<int>();

            foreach (string strNum in stringNumbers)
            {
                string normalizedNum = strNum.Replace(',', '.');

                if (double.TryParse(normalizedNum, CultureInfo.InvariantCulture, out double number))
                {
                    if (number == Math.Floor(number) && Math.Abs(number) <= 9)
                    {
                        singleDigitNumbers.Add((int)number);
                    }
                }
            }

            if (singleDigitNumbers.Count == 0) return 0;

            int max = singleDigitNumbers[0];
            int min = singleDigitNumbers[0];

            foreach (int num in singleDigitNumbers)
            {
                if (num > max) max = num;
                if (num < min) min = num;
            }

            double result = max - min;

            return Math.Round(result, 3);
        }
    }
}
