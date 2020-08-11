using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca
{
    public abstract class Pessoa
    {
        //Construtor método chamado sempre que a classe é instanciada --ctor
        public Pessoa(int id, string nome)
        {
            Id = id;
            Nome = nome;

        }

        public int Id { get; set; }

        public DateTime DataDeNascimento { get; set; }

        public string Nome { get; set; }

        public bool Sexo { get; set; }

        public char EstadoCivil { get; set; }

        public virtual void Comer()
        {
            Console.WriteLine($"Eu {Nome} estou com fome e fui comer.");
        }

        public virtual void NecessidadesFisiologicas()
        {
            Console.WriteLine($"Eu {Nome} vou ao banheiro.");
        }

        //Método abstrato o filho é obrigado a implementar o mesmo
        public abstract void Caminhar();
    }
}
