using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class GetESetSegundoExemplo
    {
        //por padrão já esta privado mas pode colocar o "Private" se quiser
        public class CarroOpcional
        {

            private double desconto = 0.1;
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
            public double Desconto
            //jeito mais simples de declarar ou
            //propriedade autoimplementada
            {
                get; set;

            }
            public double Preco { get; set; }




            //calculo de desconto
            public double PrecoDesconto
            {
                get
                {
                    return Preco - (desconto * Preco);
                }
            }
            //Criando o Construtar Personalizado
            public CarroOpcional(string nome, double preco) {
                Nome = nome;
                Preco = preco;
            }
        }
        public static void Executar()
        {
            var op = new CarroOpcional("Aerofólio", 1.500);
            var op2 = new CarroOpcional("Ar condicionado", 3.200);
            Console.WriteLine(op.PrecoDesconto);
            Console.WriteLine(op2.PrecoDesconto);


        }
    }
}
