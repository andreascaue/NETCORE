using System;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criação do Objeto Pessoa
            Pessoa Eu = new Pessoa();
            Eu.Id = 1;
            Eu.Sexo = true;
            Eu.EstadoCivil = 'C';
            Eu.Nome = "JoKelcio";

            //Pode ser criado já editando as propriedades
            Pessoa voce = new Pessoa()
            {
                DataDeNascimento = new DateTime(1970, 12, 30),
                Id = 1,
                Nome = "Sizenando",
                Sexo = true,
                EstadoCivil = 'S'                
            };

            Eu.Comer();
            Eu.NecessidadesFisiologicas();

            voce.Comer();
            voce.NecessidadesFisiologicas();

            Crianca filho = new Crianca() {
                DataDeNascimento = new DateTime(1970, 12, 30),
                Id = 1,
                Nome = "Tiru",
                Sexo = true,
                EstadoCivil = 'S'
            };

            filho.Comer();
            filho.NecessidadesFisiologicas();
        }
    }

    class ClasseMae {
        //virtual permite que o metodo seja sobre escrito.
        public virtual void MeuMetodo() {

        }
    }

    //Heranca - herda da classe mae
    class ClasseFilha : ClasseMae {

        //Override permite que o método da classe pai seja sobre escrito.
        public override void MeuMetodo()
        {
            //base serve para utilizar o método da classe pai.
            base.MeuMetodo();
            
        }
    }
}
