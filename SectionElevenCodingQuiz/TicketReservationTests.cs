namespace SectionElevenCodingQuiz
{
    using System;
    using NUnit.Framework;

    [Category("Ticket Reservation")]
    public class TicketReservationTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestPlayTicket()
        {
            Play playTicket = new Play("1001", 14.90M, 11, "Levski", "CSKA");
            Console.WriteLine(playTicket);
            Assert.AreEqual("Levski", playTicket.HomeTeam);
        }

        [Test]
        public void TestLectureTicket()
        {
            Lecture lectureTicket = new Lecture("2001", 0, 21, "Kamen Yosifov");
            Console.WriteLine(lectureTicket);
            Assert.AreEqual("Kamen Yosifov", lectureTicket.LecturerName);
        }

        [Test]
        public void TestMusicalTicket()
        {
            Musical musicalTicket = new Musical("3001", 30, 31, "AC/DC");
            Console.WriteLine(musicalTicket);
            Assert.AreEqual("AC/DC", musicalTicket.MusicianName);
        }
    }
}