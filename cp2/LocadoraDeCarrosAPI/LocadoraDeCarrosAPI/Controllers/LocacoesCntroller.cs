using LocadoraDeCarrosAPI.Data;
using LocadoraDeCarrosAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

/// <summary>
/// Controlador responsável pelo cálculo de locações de veículos.
/// </summary>
[Route("api/locacoes_CP2")]
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
    /// Calcula o valor total de uma locação com base no carro escolhido e nas datas informadas.
    /// </summary>
    /// <param name="request">Objeto contendo ID do carro, data de início e data de fim da locação.</param>
    /// <returns>Resumo da locação com modelo, marca, período, valores e desconto aplicado.</returns>
    /// <response code="200">Cálculo realizado com sucesso</response>
    /// <response code="400">Dados inválidos</response>
    /// <response code="404">Carro não encontrado</response>
    [HttpPost("calcular")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<object>> CalcularLocacao([FromBody] LocacaoRequest request)
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

        // Calcula o valor total da locação
        int dias = (request.DataFim - request.DataInicio).Days;
        double subtotal = dias * carro.ValorDiaria;
        double desconto = dias >= 7 ? 0.1 : dias >= 3 ? 0.05 : 0;
        double valorFinal = subtotal * (1 - desconto);

        // Retorna os dados formatados
        return Ok(new
        {
            carro = carro.Modelo,
            marca = carro.Marca,
            dataInicio = request.DataInicio.ToString("yyyy-MM-dd"),
            dataFim = request.DataFim.ToString("yyyy-MM-dd"),
            valorDiaria = carro.ValorDiaria,
            subtotal,
            desconto = $"{desconto * 100}%",
            valorFinal
        });
    }
}