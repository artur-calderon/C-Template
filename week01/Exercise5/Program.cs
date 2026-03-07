using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please Enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }

        static double SquareNumber(double number)
        {
            double square = number * number;
            return square;
        }

        static void DisplayResult(string name, double squareResult)
        {
            Console.WriteLine($"{name}, The square of your number is {squareResult}");
        }


        DisplayWelcome();
        string userName = PromptUserName();
        int number = PromptUserNumber();

        double squareResult = SquareNumber(number);

        DisplayResult(userName, squareResult);



    }
}