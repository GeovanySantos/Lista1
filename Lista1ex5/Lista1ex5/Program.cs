using System;

class Program
{
    static void Main()
    {
        // Solicitar ao usuário que insira os quatro valores
        Console.WriteLine("Digite quatro valores para calcular a média:");
        Console.Write("Valor 1: ");
        double valor1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Valor 2: ");
        double valor2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Valor 3: ");
        double valor3 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Valor 4: ");
        double valor4 = Convert.ToDouble(Console.ReadLine());

        // Calcular a média aritmética dos valores
        double media = (valor1 + valor2 + valor3 + valor4) / 4;

        // Exibir o resultado
        Console.WriteLine($"A média aritmética dos valores é: {media}");
    }
}
