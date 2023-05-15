using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class VariaveisEConstantes {

        public static void Executar() {
            //variavel
            double raio = 1.3;


            //constante = n altera o valor
            const double pi = 3.14;

            double area = pi * raio * raio;
            Console.WriteLine($"A área total é de: {area}");



            string nome = "Cleiton";
            int idade = 23;
            double altura = 1.90;
            bool temGato = true;
            var sobrenome = "Perez";
            Console.WriteLine($"\nMeu nome é {nome} e meu sobrenome é {sobrenome} \nEu tenho {idade} anos \nTenho {altura} de altura e tambem tenho um gato?Rs.. {temGato}");
       


        }

    }
}
