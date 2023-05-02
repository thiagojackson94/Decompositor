using System;
using System.Collections.Generic;
using System.Text;

namespace Decompositor.Interface
{
    public interface IDivisoresNumPrimos
    {
        public List<int> ObterDivisoresPrimos(IEnumerable<int> divisores);
    }
}
