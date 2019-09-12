using System;

namespace GetUserInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, what is your first and last name?");
            string wholeName = Console.ReadLine();

            Console.WriteLine("What's your favorite number?");
            string favNum = Console.ReadLine();

            Console.WriteLine("How many pets do you currently have?");
            string numPets = Console.ReadLine();

            Console.WriteLine("What are your pets' names?");
            string namePets = Console.ReadLine();

            Console.WriteLine("What is your favorite movie?");
            string favMovie = Console.ReadLine();

            Console.WriteLine("How old are you?");
            string age = Console.ReadLine();

            Console.WriteLine("What is your main goal in life?");
            string deepLife = Console.ReadLine();

            Console.WriteLine("What is your current occupation?");
            string currOccu = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Hello! Your name is " + wholeName + ".");

            Console.WriteLine("Your favorite number is " + favNum + ".");

            Console.WriteLine("You have " + numPets + " pet(s) named " + namePets + ".");

            Console.WriteLine("Your favorite movie is " + favMovie + ".");

            Console.WriteLine("You are " + age + " years old.");

            Console.WriteLine("Your main goal in life is to " + deepLife + ".");

            Console.WriteLine("Your current occupation is " + currOccu + ".");
        }
    }
}
