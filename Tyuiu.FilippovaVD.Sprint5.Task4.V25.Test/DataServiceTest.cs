using System.IO;
using Tyuiu.FilippovaVD.Sprint5.Task4.V25.Lib;

namespace Tyuiu.FilippovaVD.Sprint5.Task4.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            DataService ds = new DataService();

            string path = Path.Combine(Path.GetTempPath(), "TestInputFile.txt");

            File.WriteAllText(path, "2");

            double result = ds.LoadFromDataFile(path);

            double wait = 14.17;

            Assert.AreEqual(wait, result);

            File.Delete(path);
        }
    }
}
