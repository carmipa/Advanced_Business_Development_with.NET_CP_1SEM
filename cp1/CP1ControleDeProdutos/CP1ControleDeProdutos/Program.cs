using System.Globalization;
using CP1ControleDeProdutos.classes;

namespace CP1ControleDeProdutos

{
    class Program
{
    static void Main(string[] args)
    {
        Console.Write("****************************************************");

        Console.WriteLine("Bem vindo ao gerenciamento de produtos");
        Console.WriteLine();

        // produto 1

        Produtos p1 = new Produtos();

        Console.WriteLine("Digite os dados do primeiro produto (1):");
        Console.WriteLine();

        Console.Write("Digite o código do produto...........: ");
        p1.Codigo = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Digite o nome do produto.............: ");
        p1.nomeProduto = Console.ReadLine();
        Console.Write("Digite a quantidade do produto.......: ");
        p1.quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Digite o valor unitário do produto...: ");
        p1.valorUnitario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Digite a quantidade de desconto......: ");
        p1.desconto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine();

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("--- Produto 1 ---");
        Console.WriteLine($"Nome..........: {p1.nomeProduto}");
        Console.WriteLine($"Quantidade....: {p1.quantidade.ToString("F2", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Valor Unitário: {p1.valorUnitario.ToString("F2", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Desconto......: {p1.desconto.ToString("F2", CultureInfo.InvariantCulture)}");
        Console.WriteLine();
        Console.WriteLine($"O valor do produto sem desconto: {p1.ValorSemDesconto().ToString("F2", CultureInfo.InvariantCulture)}" + " R$");
        Console.WriteLine($"O valor do produto com desconto: {p1.valorComDesconto().ToString("F2", CultureInfo.InvariantCulture)}" + " R$");
        Console.WriteLine("------------------------------------------------");
        Console.ResetColor();

        // produto 2

        
        Produtos p2 = new Produtos();

        Console.WriteLine("Digite os dados do segundo produto (2):");
        Console.WriteLine();

        Console.Write("Digite o código do produto...........: ");
        p2.Codigo = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Digite o nome do produto.............: ");
        p2.nomeProduto = Console.ReadLine();
        Console.Write("Digite a quantidade do produto.......: ");
        p2.quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Digite o valor unitário do produto...: ");
        p2.valorUnitario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Digite a quantidade de desconto......: ");
        p2.desconto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine();

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("--- Produto 2 ---");
        Console.WriteLine($"Nome..........: {p2.nomeProduto}");
        Console.WriteLine($"Quantidade....: {p2.quantidade.ToString("F2", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Valor Unitário: {p2.valorUnitario.ToString("F2", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Desconto......: {p2.desconto.ToString("F2", CultureInfo.InvariantCulture)}");
        Console.WriteLine();
        Console.WriteLine($"O valor do produto sem desconto: {p2.ValorSemDesconto().ToString("F2", CultureInfo.InvariantCulture)}" + " R$");
        Console.WriteLine($"O valor do produto com desconto: {p2.valorComDesconto().ToString("F2", CultureInfo.InvariantCulture)}" + " R$");
        Console.WriteLine("------------------------------------------------");
        Console.ResetColor();















        }
}
}