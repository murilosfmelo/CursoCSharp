using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class ExerciciosDeGetESet
    {

        public class Pessoas
        {

            private DateTime nascimento;
            private double altura;
            private string nome;


            public string Nome
            {
                get
                {
                    return "Opcional" + nome;
                }

                set
                {
                    nome = value;
                }

            }
            public DateTime Nascimento

            {
                get; set;

            }
            public double Altura

            {
                get; set;

            }
            public double CalculoDaIdade
            {
                get
                {
                    return DateTime.Today.Year - nascimento.Year;
                }

            }
            public void Imprimirdados()
            {

                Console.WriteLine($"Olá {nome}");
                Console.WriteLine($"VC tem {DateTime.Today.Year - Nascimento.Year}");
                Console.WriteLine($"VC tem {Altura}");
                Console.WriteLine($"Vc nasceu em {Nascimento}");
            }

            
        }
        public static void Executar()
        {

            var pessoa1 = new Pessoas();
            pessoa1.Nome = "Murilo";
            pessoa1.Altura = 1.90;
            pessoa1.Nascimento = new DateTime(2006, 06, 09);

            pessoa1.Imprimirdados();


        }
    }
}
