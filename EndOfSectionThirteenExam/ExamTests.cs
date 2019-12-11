namespace EndOfSectionThirteenExam
{
    using NUnit.Framework;
    using System;

    [Category("Exam Helper")]
    public class ExamTests
    {
        [Test]
        public void TestWeeklyWages()
        {
            try
            {
                ExamHelper.WeeklyWages();
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.GetType().Name + ": " + ex.Message);
            }
        }

        [Test]
        public void TestCalcResult()
        {
            try
            {
                ExamHelper.CalculateResult();
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.GetType().Name + ": " + ex.Message);
            }
        }

        [Test]
        public void TestNumberCheck()
        {
            try
            {
                ExamHelper.NumberCheck();
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine(ex.GetType().Name + ": " + ex.Message);
            }
        }
    }
}