using System;
using System.Collections.Generic;
using System.Text;

namespace LinqLambda.Modelagem
{
    //herda de pessoa
    public class Professor : Pessoa
    {
        public List<int> AptoParaCurso { get; set; }
    }
}
