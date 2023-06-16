using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Excecoes
{
    class PrimeiraExcecao
    {

        public class Conta
        {

            private double Saldo;

            public Conta(double saldo)
            {

                Saldo = saldo;

            }
            public void Sacar(double valor)
            {
                //fazer o tratamento de erro para o programa
                if (valor > Saldo)
                {
                    //mostrar na tela para o usuario
                    throw new ArgumentException("Saldo insuficiente");

                }
                else
                {

                    // se o usuario sacar um valor menor q o saldo
                    Saldo -= valor;
                }

            }

        }


        public static void Executar()
        {

            var Conta = new Conta(3);


            try
            {

                //vamos tentar sacar, se der certo o valor será retirado
                Conta.Sacar(500);

                Console.WriteLine("Valor retirado com sucesso!");

            }

            catch (Exception ex)
            {

                //aqui vamos receber a exceção(erro) q foi lançado
                Console.WriteLine(ex.Message);

            }
            //além do try e cath temos o finally q é executado em qualquer situação
            finally { 



                Console.WriteLine("Obrigado Rs..");

            }

        }

    }
}

