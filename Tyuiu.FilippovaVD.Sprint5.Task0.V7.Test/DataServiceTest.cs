using System.IO;
using Tyuiu.FilippovaVD.Sprint5.Task0.V7.Lib;

namespace Tyuiu.FilippovaVD.Sprint5.Task0.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            DataService ds = new DataService();

            int x = 4;
            string path = ds.SaveToFileTextData(x);

            bool fileExists = File.Exists(path);
            Assert.IsTrue(fileExists);

            string fileContent = File.ReadAllText(path);
            double result = Convert.ToDouble(fileContent);

            double wait = -6;
            Assert.AreEqual(wait, result);
        }
    }
}