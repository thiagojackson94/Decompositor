using System;
using System.Linq;
using System.Text;
using Decompositor.Interface;

namespace Decompositor.Servicos
{
    public class DecompositorMaster : IDecompositor
    {
        private readonly Divisores _divisores;
        private readonly DivisorNumPrimos _numerosPrimosServico;        

        public DecompositorMaster()
        {
           _divisores = new Divisores();
           _numerosPrimosServico = new DivisorNumPrimos();
        }


        public string DecomporNumero(string numEntrada)
        {
            if (!ValidaNumEntrada(numEntrada))
            {
                return ("O numero informado deve ser um numero positivo.");
            }

            var numEntradaConvertido = Convert.ToInt32(numEntrada);
            var divisores = _divisores.ObterDivisores(numEntradaConvertido);
            var divisorePrimos = _numerosPrimosServico.ObterDivisoresPrimos(divisores);

            var builder = new StringBuilder();
            builder.AppendLine("Numero de Entrada: " + numEntrada);
            builder.AppendLine("Divisores: " + string.Join(", ", divisores.ToArray()));
            builder.AppendLine(divisorePrimos.Any() ? "Divisores Primos: " + string.Join(", ", divisorePrimos.ToArray()) : "O numero " + numEntrada + " não possui divisores primos");

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
