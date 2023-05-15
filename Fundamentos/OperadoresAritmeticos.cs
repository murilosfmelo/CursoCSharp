using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class OperadoresAritmeticos
    {
        public static void Executar() {
            Console.WriteLine("Escreva um numero");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Escreva outro numero");
            int n2 = int.Parse(Console.ReadLine());
        

            Console.WriteLine($"{n1} + {n2} = {n1+n2}");
            Console.WriteLine($"{n1} / {n2} = {n1 / n2}");
            Console.WriteLine($"{n1} - {n2} = {n1 - n2}");
            Console.WriteLine($"{n1} * {n2} = {n1 * n2}");
            Console.WriteLine($"{n1} % {n2} = {n1 % n2}");

            



        }
    }
}
