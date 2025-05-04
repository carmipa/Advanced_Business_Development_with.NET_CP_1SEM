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
        public int CarroId { get; set; }

        /// <summary>
        /// Data de início da locação.
        /// </summary>
        public DateTime DataInicio { get; set; }

        /// <summary>
        /// Data de fim da locação.
        /// </summary>
        public DateTime DataFim { get; set; }
    }
}