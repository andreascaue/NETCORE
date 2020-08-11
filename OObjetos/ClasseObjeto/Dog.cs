using System;
using System.Collections.Generic;
using System.Text;

namespace ClasseObjeto
{
    public class Dog
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Porte { get; set; }

        public string NomeDoDono { get; set; }

        public string CorDoPelo { get; set; }

        public void Comer() {
            Console.WriteLine($"O dog {Nome} comecou a comer");
        }

        public string Latir()
        {
            return "Au au au";
        }

        public void Passear(bool estaChovendo)
        {
            if (estaChovendo)
                Console.WriteLine($"Sinto muito, mas o dog {Nome} nao vai passar");
            else
                Console.WriteLine($"O dog {Nome} vai passear");
        }

    }
}
