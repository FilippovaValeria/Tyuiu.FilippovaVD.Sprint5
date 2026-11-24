using System.IO;
using Tyuiu.FilippovaVD.Sprint5.Task6.V27.Lib;

namespace Tyuiu.FilippovaVD.Sprint5.Task6.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            DataService ds = new DataService();

            string path = Path.Combine(Path.GetTempPath(), "TestTask6.txt");

            File.WriteAllText(path, "Тут есть числа 123, 456, 789, а также 12, 1234 и 5.");

            int result = ds.LoadFromDataFile(path);

            Assert.AreEqual(3, result);

            File.Delete(path);
        }
    }
}
