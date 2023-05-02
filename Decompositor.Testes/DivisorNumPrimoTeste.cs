using NUnit.Framework;
using Decompositor.Servicos;

namespace Decompositor.Testes
{
    public class DivisorNumPrimoTeste
    {
        public DivisorNumPrimos DivisorNumPrimos;

        [SetUp]
        public void Setup()
        {
            DivisorNumPrimos = new DivisorNumPrimos();
        }

        [Test]
        public void DivisoresPrimosNum10()
        {
            var respostaEsperada = new int[] { 2, 5};
            int[] divisoresTeste = new int[] { 1, 2, 5, 10 };
            var resultado = DivisorNumPrimos.ObterDivisoresPrimos(divisoresTeste);
            Assert.AreEqual(respostaEsperada, resultado);
        }

        [Test]
        public void DivisoresPrimosVazio()
        {
            var respostaEsperada = new int[] { };
            int[] divisoresTeste = new int[] { };
            var resultado = DivisorNumPrimos.ObterDivisoresPrimos(divisoresTeste);
            Assert.AreEqual(respostaEsperada, resultado);
        }
    }
}
