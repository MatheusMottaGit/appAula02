using appAula02.uteis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestExemplos
{
    [TestClass]
    public class TestFibonacci
    {
        [TestMethod]
        public void TestFiboSeq() {
            int chosenPosition = 6;
            int numberInPosition;

            Fibonacci fibonacci = new Fibonacci();

            numberInPosition = fibonacci.generateFiboSeq(chosenPosition);

            Assert.AreEqual(8, numberInPosition);
        }
    }
}
