namespace CP1ControleDeProdutos.classes;

 class Produtos
{
    // 

    /// <summary>
    /// criação dos atributos privados
    /// </summary>
    private int codigo;
    private string nomeProduto;
    private int quantidade;
    private double valorUnitario;
    private double desconto;
    private double valorTotal;

    /// <summary>
    /// construtor cheio
    /// </summary>
    public Produtos(int codigo, string nomeProduto, int quantidade, double valorUnitario, double desconto)
    {
        this.codigo = codigo;
        this.nomeProduto = nomeProduto;
        this.quantidade = quantidade;
        this.valorUnitario = valorUnitario;
        this.desconto = desconto;
        this.valorTotal = 0.0;
    }

    /// <summary>
    /// metodos get
    /// </summary>
    public int Codigo => codigo;
    public string NomeProduto => nomeProduto;
    public int Quantidade => quantidade;
    public double ValorUnitario => valorUnitario;
    public double Desconto => desconto;
    public double ValorTotal => valorTotal;

    /// <summary>
    ///método de cálculo de desconto
    /// </summary>
    public double ValorSemDesconto()
    {
        valorTotal = quantidade * valorUnitario;
        return valorTotal;
    }

    /// <summary>
    /// metodo de calculo com valor final com desconto
    /// </summary>
    public double ValorComDesconto()
    {
        double total = ValorSemDesconto();
        if (total > 5000)
            total -= total * (desconto / 100);
        return total;
    }

}