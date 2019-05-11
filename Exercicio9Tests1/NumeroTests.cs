using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercicio9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio9.Tests
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