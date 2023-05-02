using System.Collections.Generic;
using Decompositor.Interface;

namespace Decompositor.Servicos
{
    public class DivisorNumPrimos : IDivisoresNumPrimos
    {

        public List<int> ObterDivisoresPrimos(IEnumerable<int> divisores)
        {
            List<int> divisoresPrimos = new List<int>();

            foreach (var divisor in divisores)
            {
                if (ValidarDivisorPrimo(divisor))
                {
                    divisoresPrimos.Add(divisor);
                }
            }

            return divisoresPrimos;
        }

        private bool ValidarDivisorPrimo(int divisor)
        {
            if ((divisor % 2 == 0 && divisor != 2) || divisor == 1)
            {
                return false;
            }
            for (int i = 2; i < divisor; i++)
            {
                if (divisor % i == 0 && i != divisor)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
