using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    //A classe pode implementar diversas interfaces, apenas separadas por ','
    //'Ctrl + .' para implementar a interface
    public class Gato : ISom
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string NomeDoDono { get; set; }

        public void EmitirSom()
        {
            Console.WriteLine("Miau!");
        }
    }
}
