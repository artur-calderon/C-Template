using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        bool running = true;
        while (running)
        {
            manager.DisplayPlayerInfo();
            Console.WriteLine("Eternal Quest - Main Menu");
            Console.WriteLine("1. Create new goal");
            Console.WriteLine("2. List goals");
            Console.WriteLine("3. Record event");
            Console.WriteLine("4. Display score");
            Console.WriteLine("5. Save goals");
            Console.WriteLine("6. Load goals");
            Console.WriteLine("7. Exit");
            Console.WriteLine("Choose an option:");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                manager.CreateGoal();
            }
            else if (choice == "2")
            {
                manager.ListGoals();
            }
            else if (choice == "3")
            {
                manager.RecordEvent();
            }
            else if (choice == "4")
            {
                manager.DisplayPlayerInfo();
            }
            else if (choice == "5")
            {
                Console.WriteLine("Enter filename to save:");
                string f = Console.ReadLine();
                manager.SaveGoals(f);
            }
            else if (choice == "6")
            {
                Console.WriteLine("Enter filename to load:");
                string f = Console.ReadLine();
                manager.LoadGoals(f);
            }
            else if (choice == "7")
            {
                running = false;
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }
    }
}