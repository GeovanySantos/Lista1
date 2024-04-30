using System;

class Program
{
    static void Main()
    {
        // Solicitar ao usuário que insira o valor de cada produto
        Console.WriteLine("Digite o valor de cada produto:");

        double totalProdutos = 0;
        for (int i = 1; i <= 5; i++)
        {
            Console.Write($"Produto {i}: R$ ");
            double valorProduto = Convert.ToDouble(Console.ReadLine());
            totalProdutos += valorProduto;
        }

        // Solicitar ao usuário que insira o valor do pagamento
        Console.Write("Digite o valor do pagamento: R$ ");
        double pagamento = Convert.ToDouble(Console.ReadLine());

        // Calcular o troco
        double troco = pagamento - totalProdutos;

        // Exibir o troco
        if (troco >= 0)
        {
            Console.WriteLine($"Troco a ser devolvido: R$ {troco}");
        }
        else
        {
            Console.WriteLine("O valor do pagamento é insuficiente para cobrir o total dos produtos.");
        }
    }
}
