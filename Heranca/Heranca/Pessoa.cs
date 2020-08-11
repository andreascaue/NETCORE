using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca
{
    public class Pessoa
    {
        public int Id { get; set; }

        public DateTime DataDeNascimento { get; set; }

        public string Nome { get; set; }

        public bool Sexo { get; set; }

        public char EstadoCivil { get; set; }

        public virtual void Comer() {
            Console.WriteLine($"Eu {Nome} estou com fome e fui comer.");
        }

        public virtual void NecessidadesFisiologicas() {
            Console.WriteLine($"Eu {Nome} vou ao banheiro.");
        }
    }
}
