using Calculator;

namespace TestProject
{
    [TestClass]
    public sealed class TestCalculator
    {
        [TestMethod]
        public void TestAddMethod_PositiveNumbers()
        {
            UndsenCalculator calc = new();
            calc.Sum(15, 25);

            Assert.AreEqual(40, calc.Result);
        }

        [TestMethod]
        public void TestAddMethod_NegativeNumbers()
        {
            UndsenCalculator calc = new();
            calc.Sum(-10, -20);

            Assert.AreEqual(-30, calc.Result);
        }

        [TestMethod]
        public void TestAddMethod_AddZero()
        {
            UndsenCalculator calc = new();
            calc.Sum(10, 0);

            Assert.AreEqual(10, calc.Result);
        }

        [TestMethod]
        public void TestAddMethod_PositiveAndNegativeNumber()
        {
            UndsenCalculator calc = new();
            calc.Sum(15, -10);

            Assert.AreEqual(5, calc.Result);
        }

        [TestMethod]
        public void TestAddMethod_FloatValues()
        {
            UndsenCalculator calc = new();
            calc.Sum(10.5f, 20.3f);

            Assert.AreEqual(30.8f, calc.Result, 0.001f); 
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestAddMethod_NullInput()
        {
            UndsenCalculator calc = new();
            calc.Sum(null, 10); 
        }

        [TestMethod]
        public void TestSubMethod_PositiveNumbers()
        {
            UndsenCalculator calc = new();
            calc.Substraction(35, 25);

            Assert.AreEqual(10, calc.Result);
        }

        [TestMethod]
        public void TestSubMethod_NegativeNumbers()
        {
            UndsenCalculator calc = new();
            calc.Substraction(-20, -10);

            Assert.AreEqual(-10, calc.Result);
        }

        [TestMethod]
        public void TestSubMethod_AddZero()
        {
            UndsenCalculator calc = new();
            calc.Substraction(10, 0);

            Assert.AreEqual(10, calc.Result);
        }

        [TestMethod]
        public void TestSubMethod_PositiveAndNegativeNumber()
        {
            UndsenCalculator calc = new();
            calc.Substraction(15, -10);

            Assert.AreEqual(25, calc.Result);
        }

        [TestMethod]
        public void TestSubMethod_FloatValues()
        {
            UndsenCalculator calc = new();
            calc.Substraction(10.5f, 20.3f);

            Assert.AreEqual(-9.8f, calc.Result, 0.001f);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestSubMethod_NullInput()
        {
            UndsenCalculator calc = new();
            calc.Substraction(null, 10);
        }

    }
}
