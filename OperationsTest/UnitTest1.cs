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
            decimal result = op.Sum(2, 2);
            Assert.AreEqual(4, result);
//console prueba
        }

        [TestMethod]
        public void RestTest()
        {
            decimal result = op.Rest(4, 2);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void MultTest()
        {
            decimal result = op.Mult(2, 2);
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void DivTest()
        {
            decimal result = op.Div(12, 3);
            Assert.AreEqual(4, result);
        }
    }
}
