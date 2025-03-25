using System.Globalization;
using CP1ControleDeProdutos.classes;

namespace CP1ControleDeProdutos

{
    class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("************** Bem vindo ao controle de produtos **************");
        Console.WriteLine();

        
        /// <summary>
        /// Produto1
        /// pega "set" os dados que seram exibidos e calculados em relatórios
        /// </summary>
        /// <returns></returns>
        
        Produtos p1 = new Produtos();

        Console.WriteLine("------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine("Digite os dados do primeiro produto (1):");
        Console.WriteLine();

        Console.Write("Digite o código do produto..............: ");
        p1.Codigo = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Digite o nome do produto................: ");
        p1.NomeProduto = Console.ReadLine();
        Console.Write("Digite a quantidade do produto..........: ");
        p1.Quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Digite o valor unitário do produto..(R$): ");
        p1.ValorUnitario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Digite a porcentagem de desconto.....(%): ");
        p1.Desconto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine("------------------------------------------------");
        Console.WriteLine();

        // produto1
        Produtos p2 = new Produtos();

        Console.WriteLine("Digite os dados do segundo produto (2):");
        Console.WriteLine();

        Console.Write("Digite o código do produto..............: ");
        p2.Codigo = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Digite o nome do produto................: ");
        p2.NomeProduto = Console.ReadLine();
        Console.Write("Digite a quantidade do produto..........: ");
        p2.Quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Digite o valor unitário do produto..(R$): ");
        p2.ValorUnitario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Digite a porcentagem de desconto.....(%): ");
        p2.Desconto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine("------------------------------------------------");
        Console.WriteLine();

        // relatório
        /// <summary>
        /// Relatório
        /// exibe "get" um relatório com todas as informações das compras
        /// </summary>
        /// <returns></returns>
        
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine();
        Console.WriteLine("************** Relátorio de Produtos **************");
        Console.WriteLine();
        Console.WriteLine("--- Produto 1 ---");
        Console.WriteLine($"Nome...........: {p1.NomeProduto}");
        Console.WriteLine($"Quantidade.....: {p1.Quantidade.ToString("F2", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Valor Unitário.: {p1.ValorUnitario.ToString("F2", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Desconto.......: {p1.Desconto.ToString("F2", CultureInfo.InvariantCulture)}" + " %");
        Console.WriteLine();
        Console.WriteLine($"O valor do produto sem desconto: {p1.ValorSemDesconto().ToString("F2", CultureInfo.InvariantCulture)}" + " R$");
        Console.WriteLine("------------------------------------------------");

        Console.WriteLine("--- Produto 2 ---");
        Console.WriteLine($"Nome...........: {p2.NomeProduto}");
        Console.WriteLine($"Quantidade.....: {p2.Quantidade.ToString("F2", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Valor Unitário.: {p2.ValorUnitario.ToString("F2", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Desconto.......: {p2.Desconto.ToString("F2", CultureInfo.InvariantCulture)}" + " %");
        Console.WriteLine();
        Console.WriteLine($"O valor do produto sem desconto: {p2.ValorSemDesconto().ToString("F2", CultureInfo.InvariantCulture)}" + " R$");
        Console.WriteLine("------------------------------------------------");
        Console.WriteLine();
        Console.ResetColor();

        /// <summary>
        /// Produto1
        /// gera um novo relatório "get" agora usando estuturas de comparação e exibindo o desconto no maior valor de compra
        /// </summary>
        /// <returns></returns>
        
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("************** Relatório de desconto do produto **************");
        Console.ResetColor();
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("***** !ATENÇÃO! -- Desconto aplicado apenas a compras acima de R$ 5000 --- !ATENÇÃO! *****" );
        Console.ResetColor();
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Green;

        if (p1.ValorComDesconto() > p2.ValorComDesconto())
        {
            Console.WriteLine("*** Sua compra recebe o desconto ***");
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine($"O produto mais caro é....: {p1.NomeProduto}");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine($"Quantidade...............: {p1.Quantidade.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Valor Unitário...........: {p1.ValorUnitario.ToString("F2", CultureInfo.InvariantCulture)} R$");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine($"Valor do desconto........: {p1.Desconto.ToString("F2", CultureInfo.InvariantCulture)} %");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine($"Valor total sem desconto.: {p1.ValorSemDesconto().ToString("F2", CultureInfo.InvariantCulture)} R$");
            Console.WriteLine($"Valor total com desconto.: {p1.ValorComDesconto().ToString("F2", CultureInfo.InvariantCulture)} R$");
        }
        else
        {
            Console.WriteLine("*** O produto recebe um desconto ***");
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine($"O produto mais caro é....: {p2.NomeProduto}");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine($"Quantidade...............: {p2.Quantidade.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Valor Unitário...........: {p2.ValorUnitario.ToString("F2", CultureInfo.InvariantCulture)} R$");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine($"Valor do desconto........: {p2.Desconto.ToString("F2", CultureInfo.InvariantCulture)} %");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine($"Valor total sem desconto.: {p2.ValorSemDesconto().ToString("F2", CultureInfo.InvariantCulture)} R$");
            Console.WriteLine($"Valor total com desconto.: {p2.ValorComDesconto().ToString("F2", CultureInfo.InvariantCulture)} R$");
        }
        Console.ResetColor();






















        }
}
}