using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class ExercicioDeConversao
    {
        public static Action Executar { get; internal set; }

        class Dolar
        {
            //Lembrete: nomes de metodos precisam ser maiusculos 
            //primeiro metodo de ação

            public double Multiplicar(double a)
            {
                //retornando o metodo, pois a class não é void então precisa de um retorno 

                return a*5;
            }

            public static void Executar(){ 
            Console.WriteLine("Digite quantos reias vc quer converter");
                double a = double.Parse(Console.ReadLine());

                var dolar = new Dolar();

                var resultado = dolar.Multiplicar(a);
                Console.WriteLine(resultado);
          



                }





    }
    }
}
