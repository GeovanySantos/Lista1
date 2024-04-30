using System;

class Program
{
    static void Main()
    {
        // Solicitar ao usuário que insira os valores de X e Y
        Console.Write("Digite o valor de X: ");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o valor de Y: ");
        double y = Convert.ToDouble(Console.ReadLine());

        // Calcular X elevado a Y
        double resultado = Math.Pow(x, y);

        // Exibir o resultado
        Console.WriteLine($"O resultado de {x} elevado a {y} é: {resultado}");
    }
}
