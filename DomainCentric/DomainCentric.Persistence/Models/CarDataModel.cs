namespace DomainCentric.Persistence.Models
{
    using System.ComponentModel.DataAnnotations;

    public class CarDataModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Make { get; set; }

        [Required]
        public string Model { get; set; }

        public string Type { get; set; }

        public string ExteriorColor { get; set; }

        public string InteriorColor { get; set; }

        public int Year { get; set; }
    }
}