using autoritaereFactory;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Iron iron = new Iron(100);
            Assert.AreEqual("Iron", iron.Name);
            Assert.AreEqual(100, iron.Amount);
        }
    }
}