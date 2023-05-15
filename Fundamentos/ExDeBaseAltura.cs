using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class ExDeBaseAltura
    {
        public static void Executar(){
            Console.WriteLine("n1?");
            double n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("n2?");
            double n2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"({n1} * {n2})/2 = {(n1 * n2)/2}");

        }
    }
}
