using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class OperadoresAritmeticos {

        public static void Executar() {

            Console.WriteLine("Digite um número: ");
            double n1 = double.Parse(Console.ReadLine());


            Console.WriteLine("Digite outro número: ");
            double n2 = double.Parse(Console.ReadLine());

            double resultado = n1 + n2;

            Console.WriteLine($"A soma total foi de {resultado.ToString("#.##")}");

        }
    }
}
