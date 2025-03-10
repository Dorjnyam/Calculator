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

    [TestClass]
    public sealed class TestMemory
    {
        [TestMethod]
        public void TestMemoryStore()
        {
            Memory memory = new();
            MemoryItem item = new(10);
            memory.MemoryStore(item);
            Assert.AreEqual(10, memory.RecallMemoryItem(0));
        }

        [TestMethod]
        public void TestMemoryStore_MemoryRecall_ManyItems()
        {
            Memory memory = new();
            memory.MemoryStore(new MemoryItem(10));
            memory.MemoryStore(new MemoryItem(20));
            memory.MemoryStore(new MemoryItem(30));
            Assert.AreEqual(10, memory.RecallMemoryItem(0));
            Assert.AreEqual(20, memory.RecallMemoryItem(1));
            Assert.AreEqual(30, memory.RecallMemoryItem(2));
        }

        [TestMethod]
        public void TestMemoryRecall()
        {
            Memory memory = new();
            memory.MemoryStore(new MemoryItem(89));
            float result = memory.RecallMemoryItem(0);
            Assert.AreEqual(89, result);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void TestRecallMemoryItem_InvalidIndex()
        {
            Memory memory = new Memory();
            memory.MemoryStore(new MemoryItem(100));

            memory.RecallMemoryItem(1); 
        }

        [TestMethod]
        public void TestMemoryAdd_ValidIndex()
        {
            Memory memory = new Memory();
            memory.MemoryStore(new MemoryItem(50));

            float result = memory.MemoryAdd(0, 30);

            Assert.AreEqual(80, result);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void TestMemoryAdd_InvalidIndex()
        {
            Memory memory = new Memory();
            memory.MemoryStore(new MemoryItem(50));

            memory.MemoryAdd(1, 30); 
        }

        [TestMethod]
        public void TestMemorySubstract_ValidIndex()
        {
            Memory memory = new Memory();
            memory.MemoryStore(new MemoryItem(50));

            float result = memory.MemorySubstract(0, 30);

            Assert.AreEqual(20, result);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void TestMemorySubstract_InvalidIndex()
        {
            Memory memory = new Memory();
            memory.MemoryStore(new MemoryItem(50));

            memory.MemorySubstract(1, 30); 
        }

        [TestMethod]
        public void TestClearAllMemory()
        {
            Memory memory = new Memory();
            memory.MemoryStore(new MemoryItem(100));
            memory.MemoryStore(new MemoryItem(200));

            memory.ClearAllMemory();

            Assert.ThrowsException<IndexOutOfRangeException>(() => memory.RecallMemoryItem(0));
        }
    }
}
