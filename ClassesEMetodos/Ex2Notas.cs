using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class Ex2_Notas
    {

        public class Alunos
        {

            private double n1;
            private double n2;
            private double n3;
       
        public double N1

        {
            get; set;

        }
        public double N2

        {
            get; set;

        }
        public double N3

        {
            get; set;

        }


        public double CalculoDaNota
        {
            get
            {
                return (N1 + N2 + N3) / 3;
            }
        }
        public void Imprimirdados()
        {

            Console.WriteLine($"N1 {N1}");
            Console.WriteLine($"N2 {N2}");
            Console.WriteLine($"N3 {N3}");
            Console.WriteLine($"Resultado é {(N1 + N2 + N3) / 3}");

        }
        }
        public static void Executar()
        {

            var aluno1 = new Alunos();
            aluno1.N1 = 5.0;
            aluno1.N2 = 9.0;
            aluno1.N3 = 8.0;
            aluno1.Imprimirdados();


        }



    }//fim

}

