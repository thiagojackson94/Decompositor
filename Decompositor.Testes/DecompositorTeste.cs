using NUnit.Framework;
using Decompositor.Servicos;

namespace Decompositor.Testes
{
    public class DecompositorTeste
    {
        public DecompositorMaster Decompositor;

        [SetUp]
        public void Setup()
        {
            Decompositor = new DecompositorMaster();
        }

        [Test]
        public void DecomporNum10()
        {
            var respostaEsperada = "Numero de Entrada: 10\nDivisores: 1, 2, 5, 10\nDivisores Primos: 2, 5\n";
            var resultado = Decompositor.DecomporNumero("10");
            Assert.AreEqual(respostaEsperada, resultado);
        }

        [Test]
        public void DecomporLetras()
        {
            var respostaEsperada = "O numero informado deve ser um número positivo.";
            var resultado = Decompositor.DecomporNumero("ABC");
            Assert.AreEqual(respostaEsperada, resultado);
        }

        [Test]
        public void DecomporNumNegativo()
        {
            var respostaEsperada = "O numero informado deve ser um número positivo.";
            var resultado = Decompositor.DecomporNumero("-10");
            Assert.AreEqual(respostaEsperada, resultado);
        }
    }
}