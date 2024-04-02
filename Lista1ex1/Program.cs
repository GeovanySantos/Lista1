using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int b;
            int a;
            int area;

            Console.Write("Digite a base do retângulo: ");
            b = int.Parse(Console.ReadLine());

            Console.Write("Digite a altura do retângulo: ");
            a = int.Parse(Console.ReadLine());  

            area = b * a;

            Console.Write("A área do retãngulo é: ");
            Console.WriteLine(area);
        }
    }
}
