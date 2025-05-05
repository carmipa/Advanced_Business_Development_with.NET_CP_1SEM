using System.ComponentModel.DataAnnotations; // Necessário para [Key] e [Required]
using System.ComponentModel.DataAnnotations.Schema; // Necessário para [Table] e [DatabaseGenerated]

namespace LocadoraDeCarrosAPI.Models
{
    /// <summary>
    /// Representa um carro disponível para locação.
    /// </summary>
    [Table("Carros_CP2")]
    public class Carro
    {
        /// <summary>
        /// Identificador único do carro (Gerado pelo Banco de Dados).
        /// </summary>
        [Key] // <-- ADICIONADO
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // <-- ADICIONADO
        public int Id { get; set; }

        /// <summary>
        /// Modelo do carro (ex: Civic, Corolla).
        /// </summary>
        [Required(ErrorMessage = "O modelo do carro é obrigatório.")] // Opcional: Validação
        public string Modelo { get; set; } = string.Empty;

        /// <summary>
        /// Marca do carro (ex: Honda, Toyota).
        /// </summary>
        [Required(ErrorMessage = "A marca do carro é obrigatória.")] // Opcional: Validação
        public string Marca { get; set; } = string.Empty;

        /// <summary>
        /// Ano de fabricação do carro.
        /// </summary>
        [Range(1900, 2100, ErrorMessage = "Ano inválido.")] // Opcional: Validação
        public int Ano { get; set; }

        /// <summary>
        /// Valor da diária para locação.
        /// </summary>
        [Required(ErrorMessage = "O valor da diária é obrigatório.")] // Opcional: Validação
        [Range(0.01, double.MaxValue, ErrorMessage = "O valor da diária deve ser positivo.")] // Opcional: Validação (se manter double)
        public decimal ValorDiaria { get; set; } // <-- ALTERADO para decimal
    }
}