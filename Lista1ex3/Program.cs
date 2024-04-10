using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor da diagonal do quadrado: ");
            string input = Console.ReadLine();
            int diagonal;

            if (int.TryParse(input, out diagonal) && diagonal > 0)
            {
                int lado = diagonal / 2;

                int area = lado * lado;

                Console.WriteLine("A área do quadrado com diagonal " + diagonal + " é: " + area);
            }
            else
            {
                Console.WriteLine("Por favor, insira um número inteiro válido.");
            }

            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
