namespace BaseApp
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            string age;

            Console.WriteLine("What is your first name?");
            firstName = Console.ReadLine();

            Console.WriteLine("How old are you?");
            age = Console.ReadLine();

            string response = $"Your name is {firstName} and you are {age} years old.";
            Console.WriteLine(response);
        }
    }
}
