using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Questao1.Tests
{
    [TestClass()]
    public class NumeroTests
    {
        [TestMethod()]
        public void EhParTest()
        {
            bool resultado = Numero.EhPar(2);

            Assert.IsTrue(resultado);
        }

        [TestMethod()]
        public void EhImparTest()
        {
            bool resultado = Numero.EhPar(3);

            Assert.IsFalse(resultado);
        }
    }
}