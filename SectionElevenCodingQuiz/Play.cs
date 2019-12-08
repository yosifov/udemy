namespace SectionElevenCodingQuiz
{
    using System.Text;

    public class Play : Ticket
    {
        public Play(string number, decimal price, int seatNumber, string homeTeam, string awayTeam)
            : base(number, price, seatNumber)
        {
            this.HomeTeam = homeTeam;
            this.AwayTeam = awayTeam;
        }

        public string HomeTeam { get; private set; }

        public string AwayTeam { get; private set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Home team: {this.HomeTeam}");
            sb.Append($"Away team: {this.AwayTeam}");
            return sb.ToString();
        }
    }
}
