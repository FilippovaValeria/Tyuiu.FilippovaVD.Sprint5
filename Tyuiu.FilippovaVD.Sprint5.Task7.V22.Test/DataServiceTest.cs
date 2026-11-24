using System.IO;
using Tyuiu.FilippovaVD.Sprint5.Task7.V22.Lib;

namespace Tyuiu.FilippovaVD.Sprint5.Task7.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadDataAndSave()
        {
            DataService ds = new DataService();

            string inPath = Path.Combine(Path.GetTempPath(), "TestInTask7.txt");

            File.WriteAllText(inPath, "Привет, мир! Как дела? Хорошо.");

            string outPath = ds.LoadDataAndSave(inPath);

            Assert.IsTrue(File.Exists(outPath));

            string resultText = File.ReadAllText(outPath);

            string expectedText = "Привет# мир# Как дела# Хорошо#";

            Assert.AreEqual(expectedText, resultText);

            File.Delete(inPath);
            File.Delete(outPath);
        }
    }
}
