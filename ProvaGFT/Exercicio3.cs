using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaGFT
{
    class Exercicio3
    {
        public static void Executar()
        {
            Console.WriteLine("3. Algumas crianças super inteligentes estão vendendo sucos com a seguinte\ntabela de descontos: (vale 3 pontos)\nSuco de Limão:\n• Até 2 litros: desconto de 3 % por litro\n• Acima de 5 litros: Desconto de 5 % por litro.\nSuco de Tamarindo:\n• Até 2 litros: desconto de 4 % por litro\n• Acima de 5 litros: Desconto de 6 % por litro.\nEscreva um algoritmo que leia o número de litros vendidos, o tipo de suco\n(codificado da seguinte forma: L - limão.T - tamarindo), calcule e imprima o\nvalor a ser pago pelo cliente.\n");

            string suco;
            int litro;
            double desconto;
            double valor = 5;
            double valorDesconto;


            Console.Write("Digite qual suco você deseja (T) para tamarindo e (L) para limão: ");
            suco = (Console.ReadLine());
            Console.Write("Digite a quantidade em litros que você deseja: ");
            litro = int.Parse(Console.ReadLine());


            if (suco == "L" && litro <= 2)
            {
                desconto = valor - (valor * 0.03);
                valorDesconto = desconto * litro;
                Console.WriteLine($"Você pagará R${valorDesconto}.");
            }
            else if (suco == "L" && litro >= 5)
            {
                desconto = valor - (valor * 0.05);
                valorDesconto = desconto * litro;
                Console.WriteLine($"Você pagará R${valorDesconto}.");
            }
            else if (suco == "T" && litro <= 2)
            {
                desconto = valor - (valor * 0.04);
                valorDesconto = desconto * litro;
                Console.WriteLine($"Você pagará R${valorDesconto}. ");
            }
            else if (suco == "T" && litro >= 5)
            {
                desconto = valor - (valor * 0.06);
                valorDesconto = desconto * litro;
                Console.WriteLine($"Você pagará R${valorDesconto}. ");
            }
            else
            {
                valorDesconto = valor * litro;
                Console.WriteLine($" Você pagara o preço normal R${valorDesconto}");

            }
        
            Console.WriteLine("\nPressione ENTER para voltar ao menu.");
            Console.ReadLine();
        }


    }
}



