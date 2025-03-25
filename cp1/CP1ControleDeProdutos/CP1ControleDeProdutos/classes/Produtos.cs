namespace CP1ControleDeProdutos.classes;

public class Produtos
{
    public Produtos()
    {
    }

    public int Codigo { get; set; }
    public string nomeProduto { get; set; }
    public int quantidade { get; set; }
    public double valorUnitario { get; set; }
    public double desconto { get; set; }
    public double valorTotal { get; set; }

    /// <summary>
    /// Calcula o valor total do produto sem desconto
    /// </summary>
    /// <returns></returns>
    public double ValorSemDesconto()
    {
        double totalSemDesconto = quantidade * valorUnitario;
        return totalSemDesconto;
    }

    /// <summary>
    /// Calcula o valor total do produto com desconto
    /// </summary>
    /// <returns></returns>
    public double valorComDesconto()
    {
       
        double totalComDesconto = (quantidade * valorUnitario) - ((quantidade * valorUnitario) * (desconto / 100));

        return totalComDesconto;
    }





}