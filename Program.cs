using System;
using System.Collections.Generic;
using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.ClassesEMetodos;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Variaveis e Constantes - Fundamentos",VariaveisEConstantes.Executar },
                {"Notação Ponto - Fundamentos ",NotacaoPonto.Executar },
                {"Lendo Dados - Fundamentos",LendoDados.Executar },
                {"Formatando Números - Fundamentos ",FormatandoNumeros.Executar},
                {"Operadores Aritméticos - Fundamentos",OperadoresAritmeticos.Executar },
                {"Exercícios Operadores ",ExerciciosOperadores.Executar},
                {"Operadores Relacionais - Fundamentos",OperadoresRelacionais.Executar},
                {"Operadores Atribuição - Fundamentos", OperadoresAtribuicao.Executar},

                //Estruturas de Controle
                {"Estrutura If - Estruturas de Controle",EstruturaIf.Executar},
                {"Estrutura Switch - Estruturas de Controle",EstruturaSwitch.Executar},
                {"Estrutura While e For - Estruturas de Controle",EstruturaWhileEFor.Executar},
                {"Estrutura ForEach - Estruturas de Controle",EstuturaForEach.Executar},

                //Classes e Métodos
                {"Membros - Classes e Métodos",Membros.Executar},
                {"Construtores - Classes e Métodos",Construtores.Executar},
                {"Métodos com Retorno - Classes e Métodos",MetodosComRetorno.Executar },
               // {"Exercicios de Conversão - Classes e Metodos",ExercicioDeConversao.Executar},
               // {"Exercicios Dois - Classes e Metodos",ExercicioDois.Executar},
                {"Metodos Estaticos - Classes e Metodos",MetodosEstaticos.Executar },
                {"Params - Classes e Metodos",Params.Executar },
                  {"Get e Set - Classes e Metodos",GetSet.Executar },
                  {"Get e Set Segundo Exemplo  - Classes e Metodos",GetESetSegundoExemplo.Executar },
                  {"Exercícios de Get e Set  - Classes e Metodos",ExerciciosDeGetESet.Executar }
            }); ;

            central.SelecionarEExecutar();
        }
    }
}