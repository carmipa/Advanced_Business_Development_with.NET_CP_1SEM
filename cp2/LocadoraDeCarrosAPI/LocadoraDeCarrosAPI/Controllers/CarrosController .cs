using System.ComponentModel.DataAnnotations.Schema;
using LocadoraDeCarrosAPI.Data;
using LocadoraDeCarrosAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

/// <summary>
/// Controlador para gerenciar operações relacionadas a carros.
/// </summary>
[ApiController]
[Route("api/carros")]
public class CarrosController : ControllerBase
{
    private readonly AppDbContext _context;

    /// <summary>
    /// Construtor do controlador que recebe o contexto do banco de dados.
    /// </summary>
    /// <param name="context">Instância do banco de dados</param>
    public CarrosController(AppDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Retorna todos os carros cadastrados no sistema.
    /// </summary>
    /// <returns>Lista de carros</returns>
    /// <response code="200">Lista de carros retornada com sucesso</response>
    /// <response code="500">Erro interno no servidor</response>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult<IEnumerable<Carro>>> GetCarros()
    {
        return await _context.Carros.ToListAsync();
    }

    /// <summary>
    /// Retorna um carro específico pelo ID.
    /// </summary>
    /// <param name="id">ID do carro</param>
    /// <returns>O carro encontrado</returns>
    /// <response code="200">Carro retornado com sucesso</response>
    /// <response code="404">Carro não encontrado</response>
    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<Carro>> GetCarro(int id)
    {
        var carro = await _context.Carros.FindAsync(id);
        if (carro == null)
        {
            return NotFound("Carro não encontrado.");
        }
        return Ok(carro);
    }

    /// <summary>
    /// Adiciona um novo carro ao sistema.
    /// </summary>
    /// <param name="carro">Objeto do carro a ser cadastrado</param>
    /// <returns>O carro cadastrado</returns>
    /// <response code="201">Carro criado com sucesso</response>
    /// <response code="400">Dados inválidos para criação do carro</response>
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<Carro>> PostCarro(Carro carro)
    {
        _context.Carros.Add(carro);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetCarro), new { id = carro.Id }, carro);
    }

    /// <summary>
    /// Atualiza um carro existente pelo ID.
    /// </summary>
    /// <param name="id">ID do carro a ser atualizado</param>
    /// <param name="carroAtualizado">Dados atualizados do carro</param>
    /// <returns>O carro atualizado</returns>
    /// <response code="200">Carro atualizado com sucesso</response>
    /// <response code="404">Carro não encontrado</response>
    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> PutCarro(int id, Carro carroAtualizado)
    {
        var carro = await _context.Carros.FindAsync(id);
        if (carro == null)
        {
            return NotFound("Carro não encontrado.");
        }

        carro.Modelo = carroAtualizado.Modelo;
        carro.Marca = carroAtualizado.Marca;
        carro.Ano = carroAtualizado.Ano;
        carro.ValorDiaria = carroAtualizado.ValorDiaria;

        await _context.SaveChangesAsync();
        return Ok(carro);
    }

    /// <summary>
    /// Exclui um carro pelo ID.
    /// </summary>
    /// <param name="id">ID do carro a ser excluído</param>
    /// <returns>Status da operação</returns>
    /// <response code="200">Carro excluído com sucesso</response>
    /// <response code="404">Carro não encontrado</response>
    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> DeleteCarro(int id)
    {
        var carro = await _context.Carros.FindAsync(id);
        if (carro == null)
        {
            return NotFound("Carro não encontrado.");
        }

        _context.Carros.Remove(carro);
        await _context.SaveChangesAsync();
        return Ok("Carro excluído com sucesso.");
    }
}