using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca
{
    public class Crianca : Pessoa
    {
        public override void Comer()
        {
            //operador ternario, caso Sexo seja true a variavel artigo recebe o, caso seja falso recebe a
            var artigo = Sexo ? "o" : "a";

            Console.WriteLine($"Algum adulto iniciou a alimentacao d{artigo} {Nome}");
        }

        public override void NecessidadesFisiologicas()
        {
            //operador ternario, caso Sexo seja true a variavel artigo recebe o, caso seja falso recebe a
            var artigo = Sexo ? "o" : "a";

            Console.WriteLine($"Algum adulto iniciou o banho d{artigo} {Nome}");
        }
    }
}
