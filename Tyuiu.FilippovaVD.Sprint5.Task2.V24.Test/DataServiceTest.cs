using System.IO;
using Tyuiu.FilippovaVD.Sprint5.Task2.V24.Lib;

namespace Tyuiu.FilippovaVD.Sprint5.Task2.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            DataService ds = new DataService();

            int[,] matrix = {
                { 6, 0, 6 },
                { -1, -8, 7 },
                { 5, 1, 0 }
            };

            string path = ds.SaveToFileTextData(matrix);

            Assert.IsTrue(File.Exists(path));

            string[] lines = File.ReadAllLines(path);

            Assert.HasCount(3, lines);

            Assert.AreEqual("1;0;1", lines[0]);

            Assert.AreEqual("0;0;1", lines[1]);

            Assert.AreEqual("1;1;0", lines[2]);
        }
    }
}
