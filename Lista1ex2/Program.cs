using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor da aresta do quadrado: ");
            int aresta = Convert.ToInt32(Console.ReadLine());

            int area = aresta * aresta;

            Console.WriteLine("A área do quadrado com aresta " + aresta + " é: " + area);
        }
    }
}
