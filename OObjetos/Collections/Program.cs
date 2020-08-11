using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nomes = new List<string>();

            nomes.Add("Sizenanado");
            nomes.Add("Valdisnei");
            nomes.Add("Joseklecio");

            //Percorrer a lista inteira, alterando os valores.
            nomes.ForEach(x => { x += "!"; Console.WriteLine(x); });

            Console.WriteLine(nomes[0]);


            // Coloca em ordem, nesse caso numérica, sem que você mande fazer isso.
            //Fomarto <chave , valor> podemos determinar o tipo de dado.
            //Não é possível incluir dois itens com a mesma chave, gera uma exception.
            SortedList<int, int> dados = new SortedList<int, int>();
            dados.Add(5, 15);
            dados.Add(1, 11);
            dados.Add(2, 12);
            dados.Add(4, 14);
            dados.Add(3, 13);

            //Nesse caso o valor [2] se refere a chave 2 e não ao índice do array.
            Console.WriteLine(dados[2]);

            //Usado com chave e valor <chave , valor>
            Dictionary<string, string> departamentos = new Dictionary<string, string>();

            departamentos.Add("TI","Tecnologia da Informacao");
            departamentos.Add("RH","Recursos Humanos");
            departamentos.Add("MKT","Marketing");
            departamentos.Add("Jrd","Juridico");

            Console.WriteLine(departamentos["RH"]);


            //Funciona com o mesmo conceito de fila
            //Primeiro que entra é o primeiro que sai            
            Queue<int> senhasFila = new Queue<int>();
            //Enqueue utilizado para adicionar um item com o valor.
            senhasFila.Enqueue(1);
            senhasFila.Enqueue(2);
            senhasFila.Enqueue(3);
            senhasFila.Enqueue(4);

            //Dequeue remove um item, remove sempre a primeira posição da fila, e exibe o valor.
            senhasFila.Dequeue();
            //Peek só exibe o valor da primeira posição da fila, mas não retira da coleção.
            Console.WriteLine(senhasFila.Peek());

            //Utilizar o conceito de pilha
            //último que entra é o primeiro que sai
            Stack<int> senhasPilha = new Stack<int>();
            //Push adicion itens 
            senhasPilha.Push(1);
            senhasPilha.Push(2);
            senhasPilha.Push(3);
            senhasPilha.Push(4);
            //pop remove itens, remove sempre o último que foi adicionado.
            senhasPilha.Pop();

            //Peek usado para leitura da última posição.
            Console.WriteLine(senhasPilha.Peek());
        }
    }
}
