using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.POO
{
    class Abstract
    {
        public abstract class Celular
        {
            public abstract string Assistente();

            public string Tocar()
            {

                return "Trim Trim Trim";
            }
        }// class celular

        public class Samsung : Celular
        {
            public override string Assistente()
            {

                return "Olá meu nome é Bixby";
            }

        }

        public static void Executar()
        {

            //  Celular c = new Celular();


        }
    }
}
