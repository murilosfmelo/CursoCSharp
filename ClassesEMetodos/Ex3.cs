using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class Ex3Animal
    {

        public class Animal

        {
            private string nome1;
            private string nome2;
            private string nome3;
            private string tipo1;
            private string tipo2;
            private string tipo3;

            public string Nome1 { get; set; }

            public string Nome2 { get; set; }

            public string Nome3 { get; set; }

            public string Tipo1 { get; set; }

            public string Tipo2 { get; set; }

            public string Tipo3 { get; set; }

            public string TiposComResultados
            {

                get
                {

                    return Tipo1 = "Cachorro";
                    return Tipo2 = "Gato";
                    return Tipo3 = "Ave";

                }

            }

            public void Imprimir()
            {

                Console.WriteLine($"O {Nome1} é um(a) {Tipo1}");

                Console.WriteLine($"O {Nome2} é um(a) {Tipo2}");

                Console.WriteLine($"O {Nome3} é um(a) {Tipo3}");


            }
        }



        public static void Executar()

        {

            var animal1 = new Animal();
            animal1.Nome1 = "";
            animal1.Tipo1 = "Cachorro";

            animal1.Nome2 = "";
            animal1.Tipo2 = "Gato";

            animal1.Nome3 = "";
            animal1.Tipo3 = "Ave";

            Console.WriteLine("Qual o nome do ANIMAL?");
            string nome = Console.ReadLine();
            Console.WriteLine("Qual o tipo do animal?");
            string tipo = Console.ReadLine();




            if (tipo == "Cachorro" || tipo == "Gato" || tipo == "Ave")

            {
                Console.WriteLine($"Olá {nome} Vc é um(a) {tipo}");

            }
            else
            {
                Console.WriteLine("Isso é uma AVE");

            }

        }
    }//class Animal
}
