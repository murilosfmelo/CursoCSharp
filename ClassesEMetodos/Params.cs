using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class Params
    {
        //usando a palavra "params" conseguimos criar vários tipos de parâmetros
        public static void Recepcionar(params string[] pessoas)
        {
            //percorrer a string
            foreach (var pessoa in pessoas) {
                Console.WriteLine($"Olá {pessoa}");
            }
        }


        public static void Executar() {
            //instanciando
            Recepcionar("Cleiton", "Mario", "Josefa", "Julia");
            
        
        }
    }
}
