using System;
using System.Threading.Tasks.Dataflow;
using System.Xml.Linq;

class Program
{
    static Journal journal = new Journal();
    static void Main(string[] args)
    {
        string[] choices = ["Write", "Display", "Load", "Save", "Quit"];
        while (true)
        {
            Console.WriteLine("Please select one of the following choices: ");

            for (int i = 0; i < choices.Length; i++)
            {
                Console.WriteLine($"{i + 1}: {choices[i]}");
            }
            Console.WriteLine("What would you like to do? ");
            int action = int.Parse(Console.ReadLine());

            switch (action)
            {
                case 1:
                    Write();
                    break;

                case 2:
                    Display();
                    break;

                case 3:
                    Load();
                    break;

                case 4:
                    Save();
                    break;

                case 5:
                    return;
            }
        }
    }

    public static void Write()
    {
        PrompGenerator randPrompt = new PrompGenerator();
        string prompt = randPrompt.GerRandomPrompt();
        Console.WriteLine(prompt);
        string answer = Console.ReadLine();


        journal.AddEntry(answer, prompt);
    }

    public static void Display()
    {
        journal.DisplayAll();
    }

    public static void Load()
    {
        Console.WriteLine("What is the filename? ");
        string filename = Console.ReadLine();
        journal.LoadFromFile(filename);
    }

    public static void Save()
    {
        Console.WriteLine("What is the filename? ");
        string filename = Console.ReadLine();
        journal.SaveToFile(filename);
    }
}