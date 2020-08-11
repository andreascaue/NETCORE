using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca
{
    public class Crianca : Pessoa

    {
        //Construtor método chamado sempre que a classe é instanciada --ctor
        //base(id, nome) para passar os parametros para a classe mãe.
        public Crianca(int id, string nome) : base(id, nome)
        {
            Id = id;
            Nome = nome;

        }

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

        //Método abstrato da classe pai
        public override void Caminhar()
        {
            Console.WriteLine($"{Nome} está andando e brincando.");
        }
    }
}
