using System.IO;
using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.FilippovaVD.Sprint5.Task6.V27.Lib
{
    public class DataService : ISprint5Task6V27
    {
        public int LoadFromDataFile(string path)
        {
            string text = File.ReadAllText(path);

            MatchCollection matches = Regex.Matches(text, @"\b\d+\b");

            int count = 0;

            foreach (Match match in matches)
            {
                if (match.Value.Length == 3)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
