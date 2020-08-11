using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public static class MeuExtensionMethod
    {
        /// <summary>
        /// É possivel criar métodos de extensão em classe já existentes, sem precisar recompilar essa classe
        /// Inclusive em tipos nativos do C#.
        /// Para isso a classe sempre tem que ser static, consequentemente o método também
        /// A primeira propriedade do seu método, vai ser a tipagem que você quer colocar no seu método static
        /// Neste caso esse método vai aparece para qualquer propriedade do tipo string.
        /// Coloco a palavra this e o tipo (String).
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static int ContadorDePalavras(this string str) {
            return str.Split(new char[] { ' ', '.', '?' },
                StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
}
