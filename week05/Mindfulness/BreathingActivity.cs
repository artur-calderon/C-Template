public class BreathingActivity : Activity
{
    public BreathingActivity(int duration) : base("Breathing", "This activity will help you relax by guiding you through slow breathing exercises. Clear your mind and focus on your breath.", duration)
    {
    }

    public void Run()
    {
        DateTime endTime = GetEndTime();

        DisplayStartMessage();
        Console.WriteLine("Get ready to start...");
        ShowSpinner(3);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("\nBreathe in...");
            ShowCountdown(4);
            Console.WriteLine("\nBreathe out...");
            ShowCountdown(4);
        }
        DisplayEndingMessage();
    }
}