using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int number;
        int userNumber;
        int tries = 0;
        number = random.Next(1, 100);
        bool answer = true;
        do
        {
            tries += 1;
            Console.WriteLine("Guess the number!");
            userNumber = int.Parse(Console.ReadLine());

            if (userNumber < number)
            {
                Console.WriteLine("Higher");

            }
            else if (userNumber > number)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine($"Congratulations! You guessed with {tries} tries");
                Console.WriteLine("Do you want to play again? yes or no");
                string response = Console.ReadLine();

                if (response.ToLower() == "no")
                {
                    break;
                }
                else
                {
                    number = random.Next(1, 100);
                }
            }
        } while (answer);
    }
}