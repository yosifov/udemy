namespace SectionQuizTests
{
    using NUnit.Framework;
    using SectionQuiz;
    using System;

    [Category("Employee")]
    public class Tests
    {
        private int number;
        private string firstName;
        private string lastName;
        private DateTime dateOfHire;
        private string jobDescription;
        private string department;
        private decimal monthlySalary;
        private Employee employee;

        [SetUp]
        public void Setup()
        {
            this.number = 9;
            this.firstName = "Kamen";
            this.lastName = "Yosifov";
            this.dateOfHire = DateTime.Now.Date;
            this.jobDescription = "CEO";
            this.department = "IT";
            this.monthlySalary = 1000M;

            this.employee = new Employee(this.number,
                this.firstName,
                this.lastName,
                this.dateOfHire,
                this.jobDescription,
                this.department,
                this.monthlySalary);
        }

        [Test]
        public void GetFullNameTest()
        {
            string employeeFullName = this.employee.GetFullName();

            Assert.AreEqual("Kamen Yosifov", employeeFullName);
        }

        [Test]
        public void GetFullNameForSortingTest()
        {
            string employeeFullNameForSorting = this.employee.GetFullNameForSorting();

            Assert.AreEqual("Yosifov, Kamen", employeeFullNameForSorting);
        }
    }
}