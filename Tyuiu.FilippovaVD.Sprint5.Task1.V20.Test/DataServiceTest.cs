using System.IO;
using Tyuiu.FilippovaVD.Sprint5.Task1.V20.Lib;

namespace Tyuiu.FilippovaVD.Sprint5.Task1.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            DataService ds = new DataService();

            int start = -5;
            int stop = 5;

            string path = ds.SaveToFileTextData(start, stop);

            bool fileExists = File.Exists(path);
            Assert.IsTrue(fileExists);

            string[] lines = File.ReadAllLines(path);

            Assert.HasCount(11, lines);

            string[] firstLineParts = lines[0].Split(';');

            Assert.AreEqual("-5", firstLineParts[0]);

            string actualValue = firstLineParts[1].Replace(',', '.');

            Assert.AreEqual("-15.4", actualValue);
        }
    }
}