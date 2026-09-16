using Tyuiu.KaraschukNE.Sprint0.Task2.Lib;

namespace namespace_Tyuiu.KaraschukNE.Sprint0.Task2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Никита";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет..., Никита", res);

        }
    }
}
