using System.ComponentModel.DataAnnotations;

namespace LocadoraDeCarrosAPI.Models
{
    /// <summary>
    /// Representa uma solicitação de locação de veículo.
    /// </summary>
    public class LocacaoRequest
    {
        /// <summary>
        /// ID do carro que será locado.
        /// </summary>
        [Required(ErrorMessage = "O ID do carro é obrigatório.")]
        public int CarroId { get; set; }

        /// <summary>
        /// Data de início da locação.
        /// </summary>
        [Required(ErrorMessage = "A data de início é obrigatória.")]
        public DateTime DataInicio { get; set; }

        /// <summary>
        /// Data de fim da locação.
        /// </summary>
        [Required(ErrorMessage = "A data de fim é obrigatória.")]
        [Compare(nameof(DataInicio), ErrorMessage = "A data de fim deve ser posterior à de início.")]
        public DateTime DataFim { get; set; }

    }
}