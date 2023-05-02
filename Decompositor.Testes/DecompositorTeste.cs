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
            var respostaEsperada = "Número de Entrada: 10\r\nDivisores: 1, 2, 5, 10\r\nDivisores Primos: 2, 5\r\n";
            var resultado = Decompositor.DecomporNumero("10");
            Assert.AreEqual(respostaEsperada, resultado);
        }

        //[Test]
        //public void DecomporLetras()
        //{
        //    var respostaEsperada = "O número informado deve ser um número positivo.";
        //    var resultado = Decompositor.DecomporNumero("ABC");
        //    Assert.AreEqual(respostaEsperada, resultado);
        //}

        //[Test]
        //public void DecomporNumNegativo()
        //{
        //    var respostaEsperada = "O número informado deve ser um número positivo.";
        //    var resultado = Decompositor.DecomporNumero("-10");
        //    Assert.AreEqual(respostaEsperada, resultado);
        //}
    }
}