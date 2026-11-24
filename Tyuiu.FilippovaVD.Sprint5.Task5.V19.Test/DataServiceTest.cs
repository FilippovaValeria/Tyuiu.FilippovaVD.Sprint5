using System.IO;
using Tyuiu.FilippovaVD.Sprint5.Task5.V19.Lib;

namespace Tyuiu.FilippovaVD.Sprint5.Task5.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            DataService ds = new DataService();

            string path = Path.Combine(Path.GetTempPath(), "TestTask5.txt");

            File.WriteAllText(path, "5.5 -8 12 4 2.0 -3 15");

            double result = ds.LoadFromDataFile(path);

            Assert.AreEqual(12, result);

            File.Delete(path);
        }
    }
}
