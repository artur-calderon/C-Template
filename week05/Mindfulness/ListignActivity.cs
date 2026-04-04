public class ListingActivity : Activity
{
    private int _count;
    private List<string> _items;

    public ListingActivity(int duration) : base("Listing", "This activity will help you reflect on the good things in your life by prompting you to list as many items as you can in a certain category.", duration)
    {
        _items = new List<string>();
    }

    public void Run()
    {
        DisplayStartMessage();
        Console.WriteLine("Get ready to start...");
        ShowSpinner(3);
        Console.WriteLine("List as many responses as you can to the following prompt:");
        GetRandomPrompt();
        ShowCountdown(5);

        DateTime endTime = GetEndTime();

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string item = Console.ReadLine();
            if (!string.IsNullOrEmpty(item))
            {
                _items.Add(item);
                _count++;
            }
        }

        Console.WriteLine($"\nYou listed {_count} items!");

        DisplayEndingMessage();
    }

    public void GetRandomPrompt()
    {
        List<string> prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?:",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
        Random rand = new Random();
        Console.WriteLine(prompts[rand.Next(prompts.Count)]);
    }


}