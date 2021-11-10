using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OperationsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SumTest()
        {
            float result = Calculadora.Operations.Sum(2, 2);
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void RestTest()
        {
            float result = Calculadora.Operations.Rest(4, 2);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void MultTest()
        {
            float result = Calculadora.Operations.Mult(2, 2);
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void DivTest()
        {
            float result = Calculadora.Operations.Div(12, 3);
            Assert.AreEqual(4, result);
        }
    }
}
