namespace DatabaseCentric.Application.Models
{
    public class CarInput
    {
        public CarInput(string make, string model, string type, string exteriorColor, string interiorColor, int year)
        {
            this.Make = make;
            this.Model = model;
            this.Type = type;
            this.ExteriorColor = exteriorColor;
            this.InteriorColor = interiorColor;
            this.Year = year;
        }

        public string Make { get; set; }

        public string Model { get; set; }

        public string Type { get; set; }

        public string ExteriorColor { get; set; }

        public string InteriorColor { get; set; }

        public int Year { get; set; }
    }
}
