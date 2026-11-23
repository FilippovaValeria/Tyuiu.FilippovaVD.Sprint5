using System.IO;
using Tyuiu.FilippovaVD.Sprint5.Task3.V2.Lib;

namespace Tyuiu.FilippovaVD.Sprint5.Task3.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            DataService ds = new DataService();

            int x = 3;

            string path = ds.SaveToFileTextData(x);

            bool fileExists = File.Exists(path);
            Assert.IsTrue(fileExists);

            double result;
            using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                result = reader.ReadDouble();
            }

            double wait = 6.695;

            Assert.AreEqual(wait, result, 0.001);
        }
    }
}
