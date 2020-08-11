using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    /// <summary>
    /// Generics é uma espécie de tipagem que não é definida na hora que a classe é escrita
    /// Nesse caso a tipagem e definida no momento que a classe é instanciada.
    ///
    ///where limita o tipo de informação que a classe vai receber como parâmetro.
    ///Nesse caso o generic só aceita como parametro a interface ICalculoValor, ou qualquer 
    ///classe que implemente essa interface
    /// </summary>
    public class CalculoGenerico<T> where T : ICalculoValor
    {
        private decimal _imposto = 0.05m;
        private decimal _lucro = 0.10m;

        public void CalcularValorUnitario(T obj)
        {
            obj.ValorFinal += obj.ValorBruto;
            obj.ValorFinal += obj.ValorBruto * _imposto;
            obj.ValorFinal += obj.ValorBruto * _lucro;
        }
    }
}
