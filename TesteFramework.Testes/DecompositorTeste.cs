using NUnit.Framework;
using TesteFramework.Servicos;

namespace TesteFramework.Testes
{
    public class DecompositorTeste
    {
        public Decompositor Decompositor;

        [SetUp]
        public void Setup()
        {
            Decompositor = new Decompositor();
        }

        [Test]
        public void DecomporNum10()
        {
            var respostaEsperada = "N�mero de Entrada: 10\r\nDivisores: 1, 2, 5, 10\r\nDivisores Primos: 2, 5\r\n";
            var resultado = Decompositor.DecomporNumero("10");
            Assert.AreEqual(respostaEsperada, resultado);
        }

        [Test]
        public void DecomporLetras()
        {
            var respostaEsperada = "O n�mero informado deve ser um n�mero positivo.";
            var resultado = Decompositor.DecomporNumero("ABC");
            Assert.AreEqual(respostaEsperada, resultado);
        }

        [Test]
        public void DecomporNumNegativo()
        {
            var respostaEsperada = "O n�mero informado deve ser um n�mero positivo.";
            var resultado = Decompositor.DecomporNumero("-10");
            Assert.AreEqual(respostaEsperada, resultado);
        }
    }
}