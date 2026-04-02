public class WriteAssignment : Assignment
{
    private string _title;


    public WriteAssignment(string title, string name, string topic) : base(name, topic)
    {
        _title = title;
    }
    public string GetWritingInformation()
    {
        return $"{_title} by {base.GetStudentName()}";

    }
}