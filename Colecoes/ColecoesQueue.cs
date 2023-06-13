using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    class ColecoesQueue
    {
        public static void Executar()
        {
            var fila = new Queue<string>();

            // vamos enfileirar

            fila.Enqueue("Cleiton");
            fila.Enqueue("Carlos");
            fila.Enqueue("Rodrigo");
            fila.Enqueue("Josiscleuda");
            fila.Enqueue("Josivalda");

            //primeiro da fila
            Console.WriteLine(fila.Peek());

            //contar a fila
            Console.WriteLine(fila.Count());

            // remover a primeira pessoa da fila
            Console.WriteLine(fila.Dequeue());
            Console.WriteLine(fila.Count());


            // verificando as pessoas 
                foreach(var pessoas in fila)
            {
                Console.WriteLine(pessoas);
            }

        }
    }
}
