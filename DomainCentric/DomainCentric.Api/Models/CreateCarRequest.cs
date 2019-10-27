namespace DomainCentric.Api.Models
{
    public class CreateCarRequest
    {
        public string Make { get; set; }

        public string Model { get; set; }

        /// <summary>
        /// Convertible, Coupe, SUV, Van, etc.
        /// </summary>
        public string Type { get; set; }

        public string ExteriorColor { get; set; }

        public string InteriorColor { get; set; }

        public int Year { get; set; }
    }
}
