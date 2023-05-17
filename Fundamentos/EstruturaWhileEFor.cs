using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class EstruturaWhileEFor
    {
        public static void Executar(){
            //WHILE
            Console.WriteLine("Até quanto vc quer contar?");
            int.TryParse(Console.ReadLine(), out int valor);

            int contador = 1;
            while (contador <=valor) {

                Console.WriteLine(contador);
                contador++;

            // /WHILE   
            
            
            }




}

    }
}
