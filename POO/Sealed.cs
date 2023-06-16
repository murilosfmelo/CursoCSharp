using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.POO
{
    class Sealed
    {

        //Essa classe(Sealed) nao é possivel fazer herança


        sealed class SemFilho
        {
            public double ValorDaFortuna()
            {
                return 1000000000;

            }

        }

        /*class SouFilho : SemFilho
        {


        }*/

        //classe que vai conseguir herdar por causa do metodo virtual
       
        class Avo
        {
            //metodos virtuais podem ser sobrescritos
            public virtual bool HonrarNomeFamilia()
            {

                return true;

            }

        }


        public static void Executar()
        {



        }
    }
}
