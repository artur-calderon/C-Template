public class PrompGenerator
{
    List<string> _prompts = new List<string>();

    public PrompGenerator()
    {
        _prompts.Add("Who was the most interesting person I interacted with today?");
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("How did I notice God's hand in my life today?");
        _prompts.Add("What was the strongest emotion I felt today?");
        _prompts.Add("If I could redo one thing today, what would it be?");
        _prompts.Add("What is one thing I learned today?");
        _prompts.Add("What made me smile or laugh today?");
        _prompts.Add("What challenge did I face today and how did I deal with it?");
        _prompts.Add("What is something I am grateful for today?");
        _prompts.Add("What is one small moment from today that I want to remember in the future?");
        _prompts.Add("What did I do today that made me feel proud?");
        _prompts.Add("What is something I want to improve tomorrow?");
    }

    public string GerRandomPrompt()
    {
        Random random = new Random();

        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

}