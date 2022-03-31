using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaGFT
{
    public class Exercicio2
    {
        public static void Executar()
        {
            Console.WriteLine("2. Faça um programa que pergunte em que turno você Trabalha.\nPeça para digitar: vale 3 pontos\nM - matutino\nV - vespertino\nN - noturno.\nImprima a mensagem “Bom dia!” ou “Boa Tarde” ou “Boa Noite” ou “Valor\ninválido”, conforme o caso.\n");
            string turno;

            Console.Write("\nQual turno você trabalha? ");
            turno = Console.ReadLine();

            switch (turno)
            {
                case "M":
                    Console.WriteLine("Bom dia!");
                    break;
                case "V":
                    Console.WriteLine("Boa tarde!");
                    break;
                case "N":
                    Console.WriteLine("Boa noite!");
                    break;
                default:
                    Console.WriteLine("Você deve digitar: M, V ou N");
                    break;
            }
            Console.WriteLine("\nPressione ENTER para voltar ao menu.");
            Console.ReadLine();

        }
    }
}
