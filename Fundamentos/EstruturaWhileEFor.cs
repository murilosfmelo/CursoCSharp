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

            //for 

            for (int contador = 1;contador <10;contador++) {

                Console.WriteLine(contador);
            }

            // /for 















            //WHILE





           Console.WriteLine("Até quanto vc quer contar?");
           int.TryParse(Console.ReadLine(), out int valor);
            ////SALTOS
          Console.WriteLine("Qual valor dos saltos");
            int.TryParse(Console.ReadLine(), out int saltos);
           
             
           int contador = 1;
         while (contador <=valor) {
          
           Console.WriteLine(contador);
            //Fazer saltos
             contador+=saltos;





            //
            //// /WHILE   


        }




    }

    }

