using System;

class Program
{
    static void Main()
    {
        // Definir a constante para a equivalência entre milhas marítimas e metros
        const double milhaMaritimaEmMetros = 1852;

        // Definir a constante para a equivalência entre quilômetros e metros
        const double quilometroEmMetros = 1000;

        // Solicitar ao usuário que insira a quantidade de milhas marítimas
        Console.Write("Digite a quantidade de milhas marítimas: ");
        double milhasMaritimas = Convert.ToDouble(Console.ReadLine());

        // Converter milhas marítimas para quilômetros
        double quilometros = (milhasMaritimas * milhaMaritimaEmMetros) / quilometroEmMetros;

        // Exibir o resultado
        Console.WriteLine($"O equivalente de {milhasMaritimas} milhas marítimas em quilômetros é: {quilometros} km");
    }
}
