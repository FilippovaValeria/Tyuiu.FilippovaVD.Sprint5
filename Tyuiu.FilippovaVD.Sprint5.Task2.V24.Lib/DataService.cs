using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.FilippovaVD.Sprint5.Task2.V24.Lib
{
    public class DataService : ISprint5Task2V24
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.csv");

            File.WriteAllText(path, "");

            int rows = matrix.GetLength(0); 
            int cols = matrix.GetLength(1); 

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        matrix[i, j] = 1;
                    }
                    else if (matrix[i, j] < 0)
                    {
                        matrix[i, j] = 0;
                    }

                    File.AppendAllText(path, matrix[i, j].ToString());

                    if (j < cols - 1)
                    {
                        File.AppendAllText(path, ";");
                    }
                }
                File.AppendAllText(path, Environment.NewLine);
            }

            return path;
        }
    }
}