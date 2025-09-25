using appAula02.uteis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TestExemplos
{
    [TestClass]
    public class TestMetrosMilimetros
    {
        [TestMethod]
        public void TestMM()
        {
            double medida = 10;
            double converted;

            MetrosMilimetros mm = new MetrosMilimetros();
            converted = mm.converter(medida);

            Assert.AreEqual(10000, converted);
        }
    }
}
