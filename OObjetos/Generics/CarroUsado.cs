using System;
using System.Collections.Generic;
using System.Text;

namespace Generics {
    public class CarroUsado : ICalculoValor
    {

        //Como implementa a Interface é obrigado a implementar as propriedades da interface.
        public decimal ValorBruto { get; set; }

        public decimal ValorFinal { get; set; }

        public CarroUsado()
        {
            ValorBruto = 30000;
        }

    }
}
