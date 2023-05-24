using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    class Membros {

        public static void Executar() {

            Pessoa pessoa1 = new Pessoa();

            pessoa1.Nome = "Cleiton Peres";
            pessoa1.Idade = 22;



            //Console.WriteLine($"Olá {pessoa1.Nome} você tem {pessoa1.Idade}  ");

            //chamando o método Apresentar
            pessoa1.ApresentarNoConsole();

        }
    }
}
