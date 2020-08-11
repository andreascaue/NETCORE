using System;
using System.Collections.Generic;
using System.Text;

namespace EstaticAbstract
{
    //Classe statica não pode ser instanciada
    public static class Calculo
    {
        //Método static 
        public static int Somar(int a, int b) {
            return a + b;
        }
    }
}
