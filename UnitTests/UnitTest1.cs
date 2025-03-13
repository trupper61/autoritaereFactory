using autoritaereFactory;

namespace UnitTests
{
    public class Tests
    {
        private Iron iron;
        [SetUp]
        public void Setup()
        {
            iron = new Iron(100);
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual("Iron", iron.Name);
            Assert.AreEqual(100, iron.Amount);
        }
    }
}