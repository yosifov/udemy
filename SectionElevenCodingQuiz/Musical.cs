namespace SectionElevenCodingQuiz
{
    using System.Text;

    public class Musical : Ticket
    {
        public Musical(string number, decimal price, int seatNumber, string musicianName) 
            : base(number, price, seatNumber)
        {
            this.MusicianName = musicianName;
        }

        public string MusicianName { get; private set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.Append($"Musician name: {this.MusicianName}");
            return sb.ToString();
        }
    }
}
