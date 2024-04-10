using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor da base do triângulo: ");
            double baseTriangulo = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor da altura do triângulo: ");
            double alturaTriangulo = Convert.ToDouble(Console.ReadLine());

            double areaTriangulo = (baseTriangulo * alturaTriangulo) / 2;

            Console.WriteLine("A área do triângulo com base " + baseTriangulo + " e altura " + alturaTriangulo + " é: " + areaTriangulo);

            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
