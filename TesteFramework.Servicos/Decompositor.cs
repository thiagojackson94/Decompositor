using System;
using System.Linq;
using System.Text;
using TesteFramework.Interface;

namespace TesteFramework.Servicos
{
    public class Decompositor : IDecompositor
    {
        private readonly Divisores _divisores;
        private readonly DivisorNumPrimos _numerosPrimosServico;        

        public Decompositor()
        {
           _divisores = new Divisores();
           _numerosPrimosServico = new DivisorNumPrimos();
        }


        public string DecomporNumero(string numEntrada)
        {
            if (!ValidaNumEntrada(numEntrada))
            {
                return ("O número informado deve ser um número positivo.");
            }

            var numEntradaConvertido = Convert.ToInt32(numEntrada);
            var divisores = _divisores.ObterDivisores(numEntradaConvertido);
            var divisorePrimos = _numerosPrimosServico.ObterDivisoresPrimos(divisores);

            var builder = new StringBuilder();
            builder.AppendLine("Número de Entrada: " + numEntrada);
            builder.AppendLine("Divisores: " + string.Join(", ", divisores.ToArray()));
            builder.AppendLine(divisorePrimos.Any() ? "Divisores Primos: " + string.Join(", ", divisorePrimos.ToArray()) : "O número " + numEntrada + " não possui divisores primos");

            return builder.ToString();
        }

        private bool ValidaNumEntrada(string numEntrada)
        {
            if (!int.TryParse(numEntrada, out int conversao))
            {
                return false;
            }

            if (conversao < 0)
            {
                return false;
            }

            return true;
        }
    }
}
