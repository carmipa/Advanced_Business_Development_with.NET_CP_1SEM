namespace CP1ControleDeProdutos.classes;

internal class Produtos
{
    /// <summary>
    /// criação de construtor padrão vázio
    /// </summary>
    public Produtos()
    {
    }

    /// <summary>
    /// criação de métods de entrada e saída de dados
    /// </summary>
    public int Codigo { get; set; }
    public string NomeProduto { get; set; }
    public int Quantidade { get; set; }
    public double ValorUnitario { get; set; }
    public double Desconto { get; set; }
    public double valorTotal { get; set; }

    /// <summary>
    /// Calcula o valor total do produto sem desconto
    /// </summary>
    /// <returns></returns>
    public double ValorSemDesconto()
    {
        return Quantidade * ValorUnitario;
        
    }

    /// <summary>
    /// Calcula o valor total do produto com desconto
    /// </summary>
    /// <returns></returns>
    public double ValorComDesconto()
    {
        double total = ValorSemDesconto();
        if (total > 5000)
            total -= total * (Desconto / 100);
        return total;
    }

}