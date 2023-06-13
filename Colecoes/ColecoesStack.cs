using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    class ColecoesStack
    {
        public static void Executar()
        {
            var pilha = new Stack();

            //adicionando items na pilha

            pilha.Push(3);
            pilha.Push("Maxwellington");
            pilha.Push(true);
            pilha.Push(3.14);

            //mostrando os itens da pilha
            foreach(var item in pilha)
            {
                Console.WriteLine($"{item}");
            }

            //tirando o item do topo
            Console.WriteLine($"Pop:  {pilha.Pop()}");


            //verificando
            foreach (var item in pilha)
            {
                Console.WriteLine($"{item}");
            }

            //usando peek
            Console.WriteLine($"Peek:  {pilha.Peek()}");

            //contando os elementos
            Console.WriteLine(pilha.Count);


        }
    }
}
