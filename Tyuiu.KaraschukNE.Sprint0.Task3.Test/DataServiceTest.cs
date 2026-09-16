using Tyuiu.KaraschukNE.Sprint0.Task3.Lib;

namespace Tyuiu.KaraschukNE.Sprint0.Task3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedValid()
        {
            Assert.AreEqual(10, DataService.Sum(5, 5));
        }
    }
}
