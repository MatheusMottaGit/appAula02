using appAula02.uteis;

namespace TestExemplos
{
    [TestClass]
    public sealed class TesteSomaDoisNumeros
    {
        [TestMethod]
        public void TestSomar()
        {
            // cenáio
            int num1 = 20;
            int num2 = 22;
            int result;

            SomaDoisNumeros somaDoisNumeros = new SomaDoisNumeros();
            // acao
            result = somaDoisNumeros.somar(num1, num2);

            // verificacao
            Assert.AreEqual(42, result);
        }
    }
}
