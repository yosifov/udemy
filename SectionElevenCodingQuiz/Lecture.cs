namespace SectionElevenCodingQuiz
{
    using System.Text;

    public class Lecture : Ticket
    {
        public Lecture(string number, decimal price, int seatNumber, string lectorName)
            : base(number, price, seatNumber)
        {
            this.LecturerName = lectorName;
        }

        public string LecturerName { get; private set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.Append($"Lecture name: {this.LecturerName}");
            return sb.ToString();
        }
    }
}
