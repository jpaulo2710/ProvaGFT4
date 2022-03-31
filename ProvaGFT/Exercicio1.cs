using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaGFT
{
    class Exercicio1
    {
        public static void Executar()
        {
            Console.WriteLine("1. Crie uma classe para representar uma pessoa, com os atributos privados\nde nome, data de nascimento e altura.Crie os métodos públicos\nnecessários para sets e gets e também um método para imprimir todos\ndados de uma pessoa.Crie um método para calcular a idade da pessoa.\n");
            Pessoa p = new Pessoa();
            p.Nome = "João";
            p.DataNascimento = new DateTime(1990, 10, 27);
            p.Altura = 1.84f;

            p.ImprimirDados();

            int idade = p.CalcularIdade();

            Console.WriteLine("Idade: " + idade);

            Console.WriteLine("\nPressione ENTER para voltar ao menu.");
            Console.ReadLine();
        }
    }
}
