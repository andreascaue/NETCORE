using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public interface ICalculoValor
    {
        //Podemos adicionar propriedades na interface, não somente assinaturas.

        public decimal ValorBruto { get; set; }

        public decimal ValorFinal { get; set; }
    }
}
