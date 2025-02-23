using Calculator;

namespace TestProject
{
    [TestClass]
    public sealed class TestCalculator
    {
        [TestMethod]
        public void TestAddMethod_valid_value()
        {
            UndsenCalculator calc = new();
            calc.Sum(10, 20);

            Assert.AreEqual(calc. == 10);
        }
    }
}
