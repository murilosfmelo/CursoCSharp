using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.POO
{
    class ExercicioPolimorfismo
    {   

        public class Cliente
        {
            public string nome;
            public string tipo;
        }

        public class Juridico : Cliente
        {
            public string cnpj;
        }

        public static void Executar()
        {
            Cliente cliente1 = new Cliente();
            Juridico cliente2 = new Juridico();

            Console.WriteLine("Digite o seu nome");
            cliente2.nome = (Console.ReadLine());
            Console.WriteLine("Você é cliente fisico ou juridico?");
            cliente2.tipo = (Console.ReadLine());

            if (cliente2.tipo == "juridico" || cliente2.tipo == "JURIDICO")
            {
                Console.WriteLine("Digite seu cnpj:");
                cliente2.cnpj = Console.ReadLine();

                Console.WriteLine($"Olá {cliente2.nome} você é um cliente: {cliente2.tipo}" );
                Console.WriteLine("E seu Cnpj é:");
                Console.WriteLine(cliente2.cnpj);
                
            }
            else if (cliente1.tipo == "fisico" || cliente1.tipo =="FISICO")
            {
                Console.WriteLine("Digite seu cpf:");
                var cpf = Console.ReadLine();

                Console.WriteLine($"Olá {cliente1.nome} você é um cliente: {cliente1.tipo}");
                Console.WriteLine("E seu cpf é:");
                Console.WriteLine(cpf);
            }
        }
    }
}
