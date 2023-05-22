using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class EstruturaForeach
    {
        public static void Executar() {

           // var palavra = "Banana";
           // foreach (var letra in palavra) {

              //  Console.WriteLine(letra);
                //A resposta vai ser banana
           // }
            //percorrendo um array
            var alunos = new string[] { "José", "Cleiton", "Maria", "Josenildo" };
            foreach (var letra in alunos)

                Console.WriteLine(alunos);
        
        }
    }
}
