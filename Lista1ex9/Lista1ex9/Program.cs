using System;

class Program
{
    static void Main()
    {
        // Solicitar ao usuário que insira o diâmetro do círculo
        Console.Write("Digite o diâmetro do círculo: ");
        double diametro = Convert.ToDouble(Console.ReadLine());

        // Calcular o raio do círculo
        double raio = diametro / 2;

        // Calcular a área do círculo
        double area = Math.PI * Math.Pow(raio, 2);

        // Exibir o resultado
        Console.WriteLine($"A área do círculo é: {area}");
    }
}
