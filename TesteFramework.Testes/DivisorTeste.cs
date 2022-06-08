using NUnit.Framework;
using TesteFramework.Servicos;

namespace TesteFramework.Testes
{
    public class DivisorTeste
    {
        public Divisores Divisores;

        [SetUp]
        public void Setup()
        {
            Divisores = new Divisores();
        }

        [Test]
        public void DivisoresNum10()
        {
            var respostaEsperada = new int[] { 1, 2, 5, 10};
            var resultado = Divisores.ObterDivisores(10);
            Assert.AreEqual(respostaEsperada, resultado);
        }

        [Test]
        public void DivisoresVazio()
        {
            var respostaEsperada = new int[] { };
            var resultado = Divisores.ObterDivisores(0);
            Assert.AreEqual(respostaEsperada, resultado);
        }

    }
}
