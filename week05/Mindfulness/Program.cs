using System;

class Program
{
    static void Main(string[] args)
    {

        while (true)
        {

            Console.WriteLine("Welcome to the Mindfulness Activities!");
            Console.WriteLine("Please select an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");

            Console.Write("Enter the number of your choice: ");
            string choice = Console.ReadLine();
            if (choice == "4")
            {
                Console.WriteLine("Thank you for participating in the Mindfulness Activities. Have a great day!");
                break;
            }
            Console.WriteLine("How long, in seconds, would you like to do the activity? ");
            int duration = int.Parse(Console.ReadLine());


            switch (choice)
            {
                case "1":
                    BreathingActivity breathingActivity = new BreathingActivity(duration);
                    breathingActivity.Run();
                    break;
                case "2":
                    ReflectingActivity reflectingActivity = new ReflectingActivity(duration);
                    reflectingActivity.Run();
                    break;
                case "3":
                    ListingActivity listingActivity = new ListingActivity(duration);
                    listingActivity.Run();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid activity.");
                    break;
            }

            Console.WriteLine("Thank you for participating in the Mindfulness Activities. Have a great day!");
        }
    }
}