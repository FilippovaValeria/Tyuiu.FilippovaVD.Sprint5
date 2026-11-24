using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.FilippovaVD.Sprint5.Task7.V22.Lib
{
    public class DataService : ISprint5Task7V22
    {
        public string LoadDataAndSave(string path)
        {
            string text = File.ReadAllText(path);

            string resultText = text
                .Replace(".", "#")
                .Replace(",", "#")
                .Replace("!", "#")
                .Replace("?", "#")
                .Replace(";", "#")
                .Replace(":", "#");

            string outPath = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V22.txt");

            File.WriteAllText(outPath, resultText);

            return outPath;
        }
    }
}
