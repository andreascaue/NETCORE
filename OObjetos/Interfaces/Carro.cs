using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{

    //A classe pode implementar diversas interfaces, apenas separadas por ','
    public class Carro : ISom
    {
        public int Id { get; set; }

        public string Modelo { get; set; }

        public string Marca { get; set; }

        public string AnoFabricacao { get; set; }

        public void EmitirSom()
        {
            Console.WriteLine("Vrummm!");
        }
    }
}
