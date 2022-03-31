using System;
using System.Collections.Generic;
using System.Linq;



namespace CursoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool escolheuSair = false;
            while (escolheuSair == false)
            {
               
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("[GFT START #4 2022 / .Net] João Paulo Gutstein\n");
                Console.ResetColor();

                Console.WriteLine("Lista de exercicios: \n");

                var central = new CentralDeExercicios(new Dictionary<string, Action>()
            {
                 {"Exercicio imprimir dados da pessoa.", ProvaGFT.Exercicio1.Executar},
                 {"Exercicio cumprimento por turno de trabalho.", ProvaGFT.Exercicio2.Executar},
                {"Exercicio desconto por suco.", ProvaGFT.Exercicio3.Executar},
                {"Exercicio verifica se pode doar sangue.", ProvaGFT.Exercicio4.Executar},
            }
                );
                central.SelecionarEExecutar();
                Console.Clear();
            }
            escolheuSair = true;
            
        }
        
        
    }
}