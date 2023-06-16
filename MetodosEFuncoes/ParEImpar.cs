using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{
    class ParEImpar
    {
        public static void Executar()
        {
            /*Vai fazer a fun ou função para int e bool. E a parte de fazer o processo seria mais simples
             * o "Numeropar = total" vai dividir por 2
             e se o resto ou resultado for igual a 0 irá retornar verdadeiro por causa do bool que só lê true ou false*/
            Func<int, bool> numero = (total) =>
            {
                if (total % 2 == 0)
                {
                    Console.WriteLine("O numero é par");
                    return true;
                }
                else
                {
                    Console.WriteLine("O numero é impar");
                    return false;
                }
            };


            //aqui é onde o usuario colocaria o numero que ele quer
            Console.WriteLine(numero(2));


        }


    }
}
