using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class ExercicioDois
    {
        class Graus
        {
            //Lembrete: nomes de metodos precisam ser maiusculos 
            //primeiro metodo de ação

            public double fath(double a)
            {
                //retornando o metodo, pois a class não é void então precisa de um retorno 

                return (a *1.8)+32;
            }

            public static void Executar()
            {
                Console.WriteLine("Digite quantos graus vc quer converter");
                double a = double.Parse(Console.ReadLine());

                var graus = new Graus();

                var resultado = graus.fath(a);
                Console.WriteLine(resultado);




            }





        }

        internal static void Executar()
        {
            throw new NotImplementedException();
        }
    }
}
