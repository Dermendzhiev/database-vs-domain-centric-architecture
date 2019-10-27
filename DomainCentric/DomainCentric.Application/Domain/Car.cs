namespace DomainCentric.Application.Domain
{
    using System;

    public class Car
    {
        public Car(string make, string model, string type, string exteriorColor, string interiorColor, int year)
        {
            this.Make = make ?? throw new ArgumentException(make);
            this.Model = model ?? throw new ArgumentException(model);

            this.Type = type;
            this.ExteriorColor = exteriorColor;
            this.InteriorColor = interiorColor;

            if (year < 1990)
            {
                throw new Exception("Cannot create a car manufactured before 1990.");
            }
            this.Year = year;
        }

        public string Make { get; private set; }

        public string Model { get; private set; }

        public string Type { get; private set; }

        public string ExteriorColor { get; private set; }

        public string InteriorColor { get; private set; }

        public int Year { get; private set; }
    }
}
