namespace SectionThirteenCodingQuiz
{
    using NUnit.Framework;
    using System;

    [Category("Body Mass Calculator")]
    public class CodingQuizTests
    {

        [Test]
        public void CalculateBMI()
        {
            try
            {
                string weight = "150";
                string heightInFeet = "6";
                string heightInInches = "72";

                BodyMassIndexCalculator bodyMassCalculator = new BodyMassIndexCalculator(
                    int.Parse(weight),
                    int.Parse(heightInFeet),
                    int.Parse(heightInInches));

                string result = bodyMassCalculator.ToString();

                Assert.AreEqual("BMI: 5.09", result);
            }
            catch (ArithmeticException arithmeticEx)
            {
                Console.WriteLine(arithmeticEx.GetType().Name + ": " + arithmeticEx.Message);
            }
            catch (FormatException formatEx)
            {
                Console.WriteLine(formatEx.GetType().Name + ": " + formatEx.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetType().Name + ": " + ex.Message);
            }
        }
    }
}