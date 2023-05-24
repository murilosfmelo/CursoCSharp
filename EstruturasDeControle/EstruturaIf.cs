using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle {
    class EstruturaIf {
        public static void Executar() {



            /* CONVERTENDO TRY PARSE */
            Console.WriteLine("Digite um número:");
            string palavra = Console.ReadLine();
            int numero;
            int.TryParse(palavra, out numero);
            Console.WriteLine($"Resultado: {numero}");
            /*Enquanto o Parse faz a conversão da informação 
             o TryParse verifica se é possível converter para depois
            fazer a conversão
            */

            /*

            double dinheiro = 3.500;

            if(dinheiro >= 4.500) {
                Console.WriteLine("Vou comprar o ps5");
            } else if(dinheiro >= 2.500 && dinheiro <= 4.500) {
                Console.WriteLine("Vou comprar um Switch");
            }else  {
                Console.WriteLine("Não vou comprar o videogame");
            }
            */
        }
    }
}
