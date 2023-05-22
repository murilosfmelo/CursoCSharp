using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class DezNumerosInteiros
    {
        public static void Executar()
        {
            //
            //  
            // EXERCICIO 1
            //    
            //     int resultado = 0;
            //     int valor = 0;
            //
            //
            //     int n1 = 0;
            //    for (n1 = 0;n1 <= 10;n1++) {
            //
            //         Console.WriteLine("Digite um Número:");
            //         valor = int.Parse(Console.ReadLine());
            // 
            //         resultado += valor;
            //
            //
            //     
            //     }
            //     Console.WriteLine($"Esse foi o resultado:{resultado}");


            ///EXERCICIO 2
            ///
            //    Console.WriteLine("Até quanto vc quer contar?");
            // int.TryParse(Console.ReadLine(), out int valor);

            //   int contador = 1;
            //  while (contador <= valor)
            //  {

            //    Console.WriteLine(contador);

            //    contador--;
            //   }

            //EXERCICIO 3


            int resultado;
            int contador = 0;

            Console.WriteLine("digite um numero");

            int n1 = int.Parse(Console.ReadLine());

            while (contador <= 10)
            {
                resultado = contador * n1;

                Console.WriteLine($" {n1} * {contador} = {resultado}");
                contador++;
            }





        }
    }
}
