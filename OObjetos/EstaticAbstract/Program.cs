using EstaticAbstract;
using System;


namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criação do Objeto Pessoa
            Adulto Eu = new Adulto(0, "JoseKlecio");
            Eu.Id = 0;
            Eu.Sexo = true;
            Eu.EstadoCivil = 'C';
            Eu.Nome = "JoKelcio";

            //Pode ser criado já editando as propriedades
            Adulto voce = new Adulto(1, "Sizenando")
            {
                DataDeNascimento = new DateTime(1970, 12, 30),
                Id = 1,
                Nome = "Sizenando",
                Sexo = true,
                EstadoCivil = 'S'
            };

            Eu.Comer();
            Eu.NecessidadesFisiologicas();
            Eu.Caminhar();

            voce.Comer();
            voce.NecessidadesFisiologicas();
            Eu.Caminhar();

            Crianca filho = new Crianca(3, "Tiru")
            {
                DataDeNascimento = new DateTime(1970, 12, 30),
                Id = 3,
                Nome = "Tiru",
                Sexo = true,
                EstadoCivil = 'S'
            };

            filho.Comer();
            filho.NecessidadesFisiologicas();
            filho.Caminhar();

            //Classe estatica nao precisa instanciar
            Console.WriteLine(Calculo.Somar(10,15));

            //Metodo estático de uma classe que não é estática, posso chamar sem estar ligado a um Objeto (instância da classe)
            //Posso chamar o método direto sem instanciar a classe
            Adulto.SayHello();
        }
    }

    class ClasseMae
    {
        //virtual permite que o metodo seja sobre escrito.
        public virtual void MeuMetodo()
        {

        }
    }

    //Heranca - herda da classe mae
    class ClasseFilha : ClasseMae
    {

        //Override permite que o método da classe pai seja sobre escrito.
        public override void MeuMetodo()
        {
            //base serve para utilizar o método da classe pai.
            base.MeuMetodo();

        }
    }
}
