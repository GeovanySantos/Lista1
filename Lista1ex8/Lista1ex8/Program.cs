using System;

class Program
{
    static void Main()
    {
        // Solicitar ao usuário que insira a temperatura em graus Celsius
        Console.Write("Digite a temperatura em graus Celsius: ");
        double celsius = Convert.ToDouble(Console.ReadLine());

        // Converter temperatura de Celsius para Fahrenheit
        double fahrenheit = (celsius * 9 / 5) + 32;

        // Exibir o resultado
        Console.WriteLine($"A temperatura equivalente em Fahrenheit é: {fahrenheit} °F");
    }
}
