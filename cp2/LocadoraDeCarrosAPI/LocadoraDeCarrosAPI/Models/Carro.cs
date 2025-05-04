namespace LocadoraDeCarrosAPI.Models
{
    /// <summary>
    /// Representa um carro disponível para locação.
    /// </summary>
    public class Carro
    {
        /// <summary>
        /// Identificador único do carro.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Modelo do carro (ex: Civic, Corolla).
        /// </summary>
        public string Modelo { get; set; } = string.Empty;

        /// <summary>
        /// Marca do carro (ex: Honda, Toyota).
        /// </summary>
        public string Marca { get; set; } = string.Empty;

        /// <summary>
        /// Ano de fabricação do carro.
        /// </summary>
        public int Ano { get; set; }

        /// <summary>
        /// Valor da diária para locação.
        /// </summary>
        public double ValorDiaria { get; set; }
    }
}