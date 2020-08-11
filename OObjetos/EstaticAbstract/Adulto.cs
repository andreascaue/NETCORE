using Heranca;
using System;
using System.Collections.Generic;
using System.Text;

namespace EstaticAbstract
{
    public class Adulto : Pessoa
    {

        //Construtor método chamado sempre que a classe é instanciada --ctor
        //base(id, nome) para passar os parametros para a classe mãe.
        public Adulto(int id, string nome) : base(id, nome)
        {
            Id = id;
            Nome = nome;

        }

        public static void SayHello() {
            Console.WriteLine("Hello");
        }

        //Método abstrato da classe pai
        public override void Caminhar(){
            Console.WriteLine($"{Nome} Só andando.");
         }
    }

}
