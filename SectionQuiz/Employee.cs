namespace SectionQuiz
{
    using System;

    public class Employee
    {
        public Employee(int number, 
            string firstNmae, 
            string lastName, 
            DateTime dateOfHire, 
            string jobDescription, 
            string department, 
            decimal monthlySalary)
        {
            this.Number = number;
            this.FirstName = firstNmae;
            this.LastName = lastName;
            this.DateOfHire = dateOfHire;
            this.JobDescription = jobDescription;
            this.Department = department;
            this.MonthlySalary = monthlySalary;
        }

        public int Number { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfHire { get; set; }

        public string JobDescription { get; set; }

        public string Department { get; set; }

        public decimal MonthlySalary { get; set; }

        public string GetFullName()
        {
            return $"{this.FirstName} {this.LastName}";
        }

        public string GetFullNameForSorting()
        {
            return $"{this.LastName}, {this.FirstName}";
        }
    }
}
