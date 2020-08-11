using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    //A classe pode implementar diversas interfaces, apenas separadas por ','
    public class Ventilador : ISom
    {
        public int Id { get; set; }

        public string Marca { get; set; }

        public string Cor { get; set; }

        public void EmitirSom()
        {
            Console.WriteLine("Zuuummmm!");
        }
    }
}
