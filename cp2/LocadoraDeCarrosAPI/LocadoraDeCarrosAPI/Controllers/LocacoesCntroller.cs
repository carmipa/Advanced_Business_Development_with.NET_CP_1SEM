using LocadoraDeCarrosAPI.Data;
using LocadoraDeCarrosAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

/// <summary>
/// Controlador responsável pelo cálculo de locações de veículos.
/// </summary>
[Route("api/locacoes")]
[ApiController]
public class LocacoesController : ControllerBase
{
    private readonly AppDbContext _context;

    /// <summary>
    /// Construtor do controlador que recebe o contexto do banco de dados.
    /// </summary>
    /// <param name="context">Instância do banco de dados</param>
    public LocacoesController(AppDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// DTO para resposta formatada do cálculo de locação.
    /// </summary>
    public class CalculoLocacaoResponseDto
    {
        public string Carro { get; set; } = string.Empty;
        public string Marca { get; set; } = string.Empty;
        public string DataInicio { get; set; } = string.Empty;
        public string DataFim { get; set; } = string.Empty;
        public string ValorDiariaFormatado { get; set; } = string.Empty;
        public decimal Subtotal { get; set; }
        public string Desconto { get; set; } = string.Empty;
        public decimal ValorFinal { get; set; }
    }

    /// <summary>
    /// Calcula o valor total de uma locação com base no carro escolhido e nas datas informadas.
    /// </summary>
    /// <param name="request">Objeto contendo ID do carro, data de início e data de fim da locação.</param>
    /// <returns>Resumo da locação com modelo, marca, período, valores e desconto aplicado.</returns>
    /// <response code="200">Cálculo realizado com sucesso</response>
    /// <response code="400">Dados inválidos</response>
    /// <response code="404">Carro não encontrado</response>
    [HttpPost("calcular")]
    [ProducesResponseType(typeof(CalculoLocacaoResponseDto), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<CalculoLocacaoResponseDto>> CalcularLocacao([FromBody] LocacaoRequest request)
    {
        // Valida se as datas foram enviadas corretamente
        if (request.DataInicio == default || request.DataFim == default)
            return BadRequest("As datas de início e fim devem ser informadas.");

        // Verifica se a data de fim é posterior à data de início
        if (request.DataFim <= request.DataInicio)
            return BadRequest("A data de fim deve ser posterior à data de início.");

        // Verifica se o carro existe no banco de dados
        var carro = await _context.Carros.FindAsync(request.CarroId);
        if (carro == null)
            return NotFound("Carro não encontrado.");

        // Garantir que o ValorDiaria seja válido antes do cálculo
        if (carro.ValorDiaria <= 0)
            return BadRequest("O valor da diária do carro deve ser maior que zero.");

        // Calcula o número de dias da locação
        int dias = (request.DataFim - request.DataInicio).Days;

        // Evita locações com período inválido
        if (dias <= 0)
            return BadRequest("Período inválido, a locação deve ter pelo menos 1 dia.");

        // Cálculo do subtotal e descontos
        decimal subtotal = dias * carro.ValorDiaria;
        decimal taxaDesconto = dias >= 7 ? 0.10m : dias >= 3 ? 0.05m : 0m;
        decimal valorDesconto = subtotal * taxaDesconto;
        decimal valorFinal = subtotal - valorDesconto;

        // Retorno formatado
        var response = new CalculoLocacaoResponseDto
        {
            Carro = carro.Modelo,
            Marca = carro.Marca,
            DataInicio = request.DataInicio.ToString("yyyy-MM-dd"),
            DataFim = request.DataFim.ToString("yyyy-MM-dd"),
            ValorDiariaFormatado = carro.ValorDiaria.ToString("F2"), // 🔥 Garante exibição correta
            Subtotal = subtotal,
            Desconto = $"{taxaDesconto * 100}%",
            ValorFinal = valorFinal
        };

        return Ok(response);
    }
}