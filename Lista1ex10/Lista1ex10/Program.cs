using System;

class Program
{
    static void Main()
    {
        // Solicitar ao usuário que insira a cotação do dólar
        Console.Write("Digite a cotação do dólar: ");
        double cotacaoDolar = Convert.ToDouble(Console.ReadLine());

        // Solicitar ao usuário que insira a quantidade de dólares
        Console.Write("Digite a quantidade de dólares: ");
        double quantidadeDolares = Convert.ToDouble(Console.ReadLine());

        // Calcular o valor em Reais
        double valorReais = quantidadeDolares * cotacaoDolar;

        // Exibir o resultado
        Console.WriteLine($"O valor correspondente em Reais é: R$ {valorReais}");
    }
}
