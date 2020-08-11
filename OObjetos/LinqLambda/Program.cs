using LinqLambda.Consultas;
using System;
using System.Security.Cryptography.X509Certificates;

namespace LinqLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsultasLambdas lambdas = new ConsultasLambdas();
            ConsultasLinq linq = new ConsultasLinq();

            lambdas.SelecionarNomeDosAlunos().ForEach(x =>
            {
                Console.WriteLine($"Alunos por lambda: {x}");
            });

            linq.SelecionarNomeDosAlunos().ForEach(x =>
            { 
                 Console.WriteLine($"Alunos pro linq: {x} ");
            });

            //Consulta com condicional
            lambdas.SelecionarProfessorPorCurso(1).ForEach(x =>
            {
                Console.WriteLine($"Professor por lambda: {x}");
            }
            );

            linq.SelecionarProfessorPorCurso(2).ForEach(x =>
            {
                Console.WriteLine($"Professor por linq: {x}");
            }
            );

            //pesquisa por texto
            Console.WriteLine(lambdas.VerificarSeCursoExiste("ultra"));
            Console.WriteLine(linq.VerificarSeCursoExiste("avançado"));

            var x = lambdas.SelecionarDadosDaTurma();

            var y = linq.SelecionarDadosDaTurma();
        }
    }
}
