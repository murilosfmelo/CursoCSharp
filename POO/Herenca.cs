using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.POO
{
    class Herenca
    {   
       //Criar class Carro
      public class Carro
        {
           protected readonly int VelocidadeMaxima;
            //A variavel velocidademaxima será transmitida por herança
            //por isso estamos usando o protected
            int VelocidadeAtual;


        public Carro (int velocidadeMaxima)
            {
                VelocidadeMaxima = velocidadeMaxima;
            }


        //criando método para acelerar o carro
        protected int AlterarVelocidade (int delta)
            {
                int novaVelocidade = VelocidadeAtual + delta;
                if (novaVelocidade<0)
                {
                    VelocidadeAtual = 0;
                }
                else if (novaVelocidade > VelocidadeMaxima)
                {
                    VelocidadeAtual = VelocidadeMaxima;
                }
                else
                {
                    VelocidadeAtual = novaVelocidade;
                }

                return VelocidadeAtual;
            }

            public int Acelerar()
            {
                return AlterarVelocidade(5);
            }

            public int Frear()
            {
                return AlterarVelocidade(-5);
            }
       }
        
        public class Uno : Carro
        {/** O numero 380 que está entre base()
            signifiaca a velocidadeMaxima que foi  herdado
            de carro usamos base para não precisar utilizar o
            construtor novamente
          */
            public Uno() : base(380)
            {

            }
        }

        public class GTR : Carro
        {
            public GTR() : base(450)
            { 
                
            }
            

        }

        public static void Executar()
        {
            Console.WriteLine("Uno..");
            //instanciar carro1 em uno
            Uno carro1 = new Uno();
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Frear());


            Console.WriteLine("GODZILLA...\n");
            GTR carro2 = new GTR();
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());


        }
    }
}
