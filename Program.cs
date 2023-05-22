using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Variaveis e constantes - Fundamentos", VariaveisEConstantes.Executar },
                {"Notação Pomto - Fundamentos ",NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos ",LendoDados.Executar},
                {"Formatando Numeros - Fundamentos",FormatandoNumeros.Executar},
                {"Operação Aritmeticas - Fundamentos",OperadoresAritmeticos.Executar},
                {"Ex Base De Altura - Fundamentos",ExDeBaseAltura.Executar },
                {"Ex 1 - Fundamnetos",Exercicios.Executar },
                {"Operadores Relacionais - Fundamentos",OperadoresRelacionais.Executar },
                {"ExerciciosNovos - Fundamentos",ExerciciosNovos.Executar },
                {"Estrutura if - Fundamentos",EstruturaIf.Executar},
                {"Estrutura Switch - Fundamentos",EstruturaSwitch.Executar},
                { "Estrutura de While e For - Fundamentos",EstruturaWhileEFor.Executar},
                {"Dez Numeros Inteiros - Fundamentos",DezNumerosInteiros.Executar},
                {"Estrutura Foreach - Fundamentos",EstruturaForeach.Executar}
            
            });

            central.SelecionarEExecutar();
        }
    }
}