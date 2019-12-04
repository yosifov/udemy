namespace SectionExam
{
    using NUnit.Framework;

    public class Tests
    {
        private int year;
        private bool leap;

        [SetUp]
        public void Setup()
        {
            this.year = 2020;
            this.leap = false;
        }

        [Test]
        public void CheckIsLeapYear()
        {
            var divBy2 = DivisibleBy2(this.year);
            var divBy4 = DivisibleBy4(this.year);
            var divBy100 = DivisibleBy100(this.year);
            var divBy400 = DivisibleBy400(this.year);

            if (divBy2)
            {
                if (divBy4)
                {
                    if (divBy100)
                    {
                        if (divBy400)
                        {
                            this.leap = true;
                            Assert.IsTrue(this.leap);
                        }
                        else
                        {
                            Assert.Fail($"{this.year} is divisible by 4 and 100 but not by 400. The year is not leap.");
                        }
                    }
                }
                else
                {
                    Assert.Fail($"{this.year} is not divisible by 4. The year is not leap.");
                }
            }
            else
            {
                Assert.Fail($"{this.year} is not divisible by 2. The year is not leap.");
            }
        }

        public bool DivisibleBy2(int number)
        {
            if (number % 2 == 0) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DivisibleBy4(int number)
        {
            if (number % 4 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DivisibleBy100(int number)
        {
            if (number % 100 == 0)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public bool DivisibleBy400(int number)
        {
            if (number % 400 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}