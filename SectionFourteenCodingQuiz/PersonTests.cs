namespace SectionFourteenCodingQuiz
{
    using NUnit.Framework;
    using System;

    [Category("Person")]
    public class PersonTests
    {
        private Person person;

        [SetUp]
        public void Setup()
        {
            this.person = new Person();
        }

        [Test]
        public void TestFirstName()
        {
            try
            {
                this.person.FirstName = "Kamen";
                Assert.Pass();
            }
            catch (ArgumentException ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [Test]
        public void TestLastName()
        {
            try
            {
                this.person.LastName = "Yosifov";
                Assert.Pass();
            }
            catch (ArgumentException ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [Test]
        public void TestAge()
        {
            try
            {
                this.person.Age = int.Parse("33");
                Assert.Pass();
            }
            catch (ArgumentException ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [Test]
        public void TestBirthDate()
        {
            try
            {
                this.person.BirthDate = "07/08/1986";
                Assert.Pass();
            }
            catch (ArgumentException ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [Test]
        public void TestPhoneNumber()
        {
            try
            {
                this.person.PhoneNumber = "(123)-456-7890";
                Assert.Pass();
            }
            catch (ArgumentException ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}