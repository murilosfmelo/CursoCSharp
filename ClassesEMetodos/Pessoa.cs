using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    class Pessoa {


        /*estamos colocando o tipo public porque
         * quero que esse atributo fique visível para a minha classe, 
         * imagine que na vida real temos alguns atributos que precisam ser 
         * publicos e outros atributos precisam ser privados*/
        public string Nome;
        public int Idade;

        public string Apresentar() {
            return string.Format($"Olá! Me chame {Nome} e tenho {Idade} anos");
        }
        /*o método Format retorna uma 
         * string formatada e imprime no console */

        public void ApresentarNoConsole() {
            //aqui eu vou chamar no console
            //o método que eu criei que é o Apresentar()
            Console.WriteLine(Apresentar());
        }

    }
}
