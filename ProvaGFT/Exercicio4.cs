using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaGFT
{
    public class Exercicio4
    {
        public static void Executar() {

            Console.WriteLine("4. A idade permitida para doar sangue é entre 18 e 67 anos. Faça um\naplicativo que pergunte a idade de uma pessoa e diga se ela pode doar\nsangue ou não.Use alguns dos operadores lógicos OU(||) e E(&&).\n");

            int idade;
            Console.Write("Digite sua idade: ");
            idade = int.Parse(Console.ReadLine());

            if (idade >= 18 && idade <= 67)
            {
                Console.WriteLine("Você pode doar sangue!");
            }
            else
            {
                Console.WriteLine("Infelizmente sua idade não lhe permite doar sangue. ");
            }
        
            Console.WriteLine("\nPressione ENTER para voltar ao menu.");
            Console.ReadLine();
        }
    }
}
