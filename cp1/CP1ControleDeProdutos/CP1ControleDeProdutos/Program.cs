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

            Console.WriteLine("Digite os dados do primeiro produto (1):");
            Console.Write("Código: ");
            int codigo1 = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Nome: ");
            string nome1 = Console.ReadLine();
            Console.Write("Quantidade: ");
            int qtd1 = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Valor unitário (R$): ");
            double valor1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Desconto (%): ");
            double desc1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Produtos p1 = new Produtos(codigo1, nome1, qtd1, valor1, desc1);

            /// <summary>
            /// Produto2
            /// pega "set" os dados que seram exibidos e calculados em relatórios
            /// </summary>
            /// <returns></returns>

            Console.WriteLine("\nDigite os dados do segundo produto (2):");
            Console.Write("Código: ");
            int codigo2 = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Nome: ");
            string nome2 = Console.ReadLine();
            Console.Write("Quantidade: ");
            int qtd2 = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Valor unitário (R$): ");
            double valor2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Desconto (%): ");
            double desc2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Produtos p2 = new Produtos(codigo2, nome2, qtd2, valor2, desc2);

            // Relatório de produtos
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n************** Relatório de Produtos **************\n");
            Console.WriteLine("--- Produto 1 ---");
            Console.WriteLine($"Nome...........: {p1.NomeProduto}");
            Console.WriteLine($"Quantidade.....: {p1.Quantidade.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Valor Unitário.: {p1.ValorUnitario.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Desconto.......: {p1.Desconto.ToString("F2", CultureInfo.InvariantCulture)} %");
            Console.WriteLine($"Valor sem desconto: {p1.ValorSemDesconto().ToString("F2", CultureInfo.InvariantCulture)} R$");

            Console.WriteLine("--- Produto 2 ---");
            Console.WriteLine($"Nome...........: {p2.NomeProduto}");
            Console.WriteLine($"Quantidade.....: {p2.Quantidade.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Valor Unitário.: {p2.ValorUnitario.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Desconto.......: {p2.Desconto.ToString("F2", CultureInfo.InvariantCulture)} %");
            Console.WriteLine($"Valor sem desconto: {p2.ValorSemDesconto().ToString("F2", CultureInfo.InvariantCulture)} R$");
            Console.ResetColor();

            // Relatório com desconto
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n************** Relatório de desconto do produto **************");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("***** !ATENÇÃO! -- Desconto aplicado apenas a compras acima de R$ 5000 --- !ATENÇÃO! *****");
            Console.ResetColor();

            Produtos produtoMaisCaro = p1.ValorComDesconto() > p2.ValorComDesconto() ? p1 : p2;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n*** Produto com desconto aplicado ***\n");
            Console.WriteLine($"Produto.........: {produtoMaisCaro.NomeProduto}");
            Console.WriteLine($"Quantidade......: {produtoMaisCaro.Quantidade.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Valor Unitário..: {produtoMaisCaro.ValorUnitario.ToString("F2", CultureInfo.InvariantCulture)} R$");
            Console.WriteLine($"Desconto........: {produtoMaisCaro.Desconto.ToString("F2", CultureInfo.InvariantCulture)} %");
            Console.WriteLine($"Total s/ desc...: {produtoMaisCaro.ValorSemDesconto().ToString("F2", CultureInfo.InvariantCulture)} R$");
            Console.WriteLine($"Total c/ desc...: {produtoMaisCaro.ValorComDesconto().ToString("F2", CultureInfo.InvariantCulture)} R$");
            Console.ResetColor();






















        }
}
}