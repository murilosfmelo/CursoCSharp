using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class EstruturaIf

       
    {
        public static void Executar()
        {

            //Convertendo TRY PARSE 

            Console.WriteLine("Digite um numero: ");
            string palavra = Console.ReadLine();
            int numero;
            int.TryParse(palavra, out numero);
            Console.WriteLine($"Resultado: {numero}");



            //Enquanto o Parse faz
            //a conversão da informação
            //o Tryparse verifica se
            //é possivel converter
            //para dps fazer a conversão
           
        }
    }
}
