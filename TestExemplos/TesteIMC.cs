using appAula02.uteis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestExemplos
{

    [TestClass]
    public class TesteIMC
    {
        [TestMethod]
        public void TesteCalculateIMC()
        {
            float peso = 80;
            float altura = 1.79F;
            float imcCalculado;

            Imc imc = new Imc();
            imcCalculado = imc.calculaImc(peso, altura);

            Assert.AreEqual(Math.Round(24.97, 2), Math.Round(imcCalculado, 2));
        }
    }
}
