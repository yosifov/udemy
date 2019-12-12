namespace SectionFourteenCodingQuiz
{
    using System;
    using System.Text.RegularExpressions;

    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private string birthDate;
        private string phoneNumber;

        public Person()
        {
        }

        public Person(string firstName, string lastName, string age, int birthDay, int birthMonth, int birthYear, string phoneNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = int.Parse(age);
            this.BirthDate = (birthDay + "/" + birthMonth + "/" + birthYear).ToString();
            this.PhoneNumber = phoneNumber;
        }

        public string FirstName
        {
            get => this.firstName;
            set
            {
                ValidateName(value, nameof(this.FirstName));
                this.firstName = value;
            }
        }

        public string LastName
        {
            get => this.lastName;
            set
            {
                ValidateName(value, nameof(this.LastName));
                this.lastName = value;
            }
        }

        public int Age
        {
            get => this.age;
            set
            {
                ValidateAge(value, nameof(this.Age));
                this.age = value;
            }
        }

        public string BirthDate
        {
            get => this.birthDate;
            set
            {
                ValidateBirthDate(value, nameof(this.BirthDate));
                this.birthDate = value;
            }
        }

        public string PhoneNumber
        {
            get => this.phoneNumber;
            set
            {
                ValidatePhoneNumber(value, nameof(this.PhoneNumber));
                this.phoneNumber = value;
            }
        }

        public static void ValidateName(string name, string type)
        {
            string pattern = @"^[a-zA-Z]+$";

            if (string.IsNullOrEmpty(name) || !Regex.IsMatch(name, pattern))
            {
                throw new ArgumentException($"{type} is not valid");
            }
        }

        public static void ValidateAge(int age, string type)
        {
            string pattern = @"^[0-9]*$";

            if (!Regex.IsMatch(age.ToString(), pattern) || age <= 0)
            {
                throw new ArgumentException($"{type} is not valid");
            }
        }

        public static void ValidateBirthDate(string birthdate, string type)
        {
            string pattern = @"^\d{2}\/\d{2}\/\d{4}$";

            if (string.IsNullOrEmpty(birthdate) || !Regex.IsMatch(birthdate, pattern))
            {
                throw new ArgumentException($"{type} is not valid");
            }

            int day = int.Parse(birthdate.Split("/")[0]);
            int month = int.Parse(birthdate.Split("/")[1]);
            int year = int.Parse(birthdate.Split("/")[2]);

            if (day <= 0 || day > 31)
            {
                throw new ArgumentException($"Birth day is not valid");
            }

            if (month < 0 || month > 12)
            {
                throw new ArgumentException($"Birth month is not valid");
            }

            if (year < 0 || year > DateTime.Now.Year)
            {
                throw new ArgumentException($"Birth year is not valid");
            }
        }

        public static void ValidatePhoneNumber(string phoneNumber, string type)
        {
            string pattern = @"^\(\d{3}\)-\d{3}-\d{4}$";

            if (string.IsNullOrEmpty(phoneNumber) || !Regex.IsMatch(phoneNumber, pattern))
            {
                throw new ArgumentException($"{type} is not valid");
            }
        }
    }
}
