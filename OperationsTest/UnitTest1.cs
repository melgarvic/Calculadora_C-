using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OperationsTest
{
    [TestClass]
    public class UnitTest1
    {
        Calculadora.Operations op = new Calculadora.Operations();

        [TestMethod]
        public void SumTest()
        {
            float result = op.Sum(2, 2);
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void RestTest()
        {
            float result = op.Rest(4, 2);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void MultTest()
        {
            float result = op.Mult(2, 2);
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void DivTest()
        {
            float result = op.Div(12, 3);
            Assert.AreEqual(4, result);
        }
    }
}
