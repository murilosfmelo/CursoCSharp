using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class OperadoresRelacionais
    {
        public static void Executar() {
            int a = 72;
            int b = 4;
            int c = 16;
            int d = 20;

            //verdadeiro
            Console.WriteLine(a>=d);

            //verdadeiro
            Console.WriteLine(b!=c);

            //falso
            Console.WriteLine(d<c);
        }
    }
}
