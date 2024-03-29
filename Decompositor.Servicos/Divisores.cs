﻿using System.Collections.Generic;
using Decompositor.Interface;

namespace Decompositor.Servicos
{
    public class Divisores : IDivisores
    {
        public List<int> ObterDivisores(int numEntrada)
        {
            var divisores = new List<int>();

            for (int i = 1; i <= numEntrada; i++)
            {
                if (numEntrada % i == 0)
                {
                    divisores.Add(i);
                }
            }

            return divisores;
        }
    }
}
