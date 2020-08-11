using System;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string Nome = "Andreas";
            string SobreNome = "Magalhães";
            bool programador = true;
            int idade = 36;

            var soma = 10 + 5;
            var subtracao = 10 - 5;
            var multiplicacao = 10 * 5;
            var divisao = 10 / 5;
            var mod = 10 % 7;


            Console.WriteLine("Hello World!");

            Console.WriteLine(Nome + " " + SobreNome + ", sua idade é: " + idade + ", ");
            Console.WriteLine($"Resultado da soma: {soma}");
            Console.WriteLine($"Resultado da subtracao: {subtracao}");
            Console.WriteLine($"Resultado da multiplicacao: {multiplicacao}");
            Console.WriteLine($"Resultado da divisao: {divisao}");
            Console.WriteLine($"Resultado do resto da divisao {mod}");
        }
    }
}
