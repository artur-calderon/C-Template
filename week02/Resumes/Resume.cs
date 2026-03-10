public class Resume
{

    public string _name;
    public List<Job> _jobs = new List<Job>();


    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs: ");
        Console.WriteLine($"Lista de jobs {_jobs[0]}");
        foreach (Job jobs in _jobs)
        {
            jobs.DisplayJob();
        }
    }

}