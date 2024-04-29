using System;

class Program
{
    static void Main()
    {
        // Solicitar ao usuário que insira os dois valores
        Console.WriteLine("Digite dois valores para calcular a média geométrica:");
        Console.Write("Valor 1: ");
        double valor1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Valor 2: ");
        double valor2 = Convert.ToDouble(Console.ReadLine());

        // Calcular a média geométrica dos valores
        double mediaGeometrica = Math.Sqrt(valor1 * valor2);

        // Exibir o resultado
        Console.WriteLine($"A média geométrica dos valores é: {mediaGeometrica}");
    }
}
