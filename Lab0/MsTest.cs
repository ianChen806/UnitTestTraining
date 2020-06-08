using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lab0
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddTest()
        {
            var target = new Calculation();

            var actual = target.Add(1, 2);

            Assert.AreEqual(3, actual);
        }
    }
}