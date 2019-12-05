namespace EndOfSectionExam
{
    using System.Text;

    public class Trip
    {
        public Trip(string destination, double distance, double gasolineCost, double gallonsUsed)
        {
            this.Destination = destination;
            this.DistanceTraveled = distance;
            this.GasolineCost = gasolineCost;
            this.GallonsConsumed = gallonsUsed;
        }

        public string Destination { get; private set; }

        public double DistanceTraveled { get; private set; }

        public double GasolineCost { get; private set; }

        public double GallonsConsumed { get; private set; }

        public double CalculateMilesPerGallon()
        {
            double milesPerHour = this.DistanceTraveled / this.GallonsConsumed;

            return milesPerHour;
        }

        public double CalculateCostPerMile()
        {
            double costPerHour = this.GasolineCost / this.DistanceTraveled;

            return costPerHour;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"Trip Destination: {this.Destination}");
            sb.AppendLine($"Distance traveled: {this.DistanceTraveled}:F2");
            sb.AppendLine($"Total cost of gasoline: {this.GasolineCost}:F2");
            sb.AppendLine($"Number of gallons consumed: {this.GallonsConsumed}:F2");
            sb.AppendLine($"Miles per gallon: {this.CalculateMilesPerGallon():F2}");
            sb.Append($"Trip cost per mile: {this.CalculateCostPerMile():F2}");

            return sb.ToString();
        }
    }
}
