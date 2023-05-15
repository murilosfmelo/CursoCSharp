using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class LendoDados
    {
        public static void Executar(){

            Console.WriteLine("Qual seu nome?");
            string nome = Console.ReadLine();

            Console.WriteLine("Sua idade");
            //FAZENDO A CONVERSÃO DE TIPO INT
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual a sua altura?");
            double altura = double.Parse(Console.ReadLine());


            //tentar exibir as variaveis em uma mensagem
        
            Console.WriteLine($"\n Seu nome é {nome} \n Você tem {idade} anos \n e {altura} de altura");



        }
    }
}
