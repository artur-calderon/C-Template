
public class Video
{
    string _title;
    string _author;
    int _duration;
    List<Comment> _comments = new List<Comment>();


    public Video(string title, string author, int duration)
    {
        _title = title;
        _author = author;
        _duration = duration;
    }

    public void AddComment(string author, string comment)
    {
        Comment newComment = new Comment();
        newComment.SetComment(author, comment);

        _comments.Add(newComment);
    }

    public int TotalComments()
    {
        return _comments.Count;
    }

    public void DisplayVideos()
    {
        Console.WriteLine($"Video Title: {_title}");
        Console.WriteLine($"Video Author: {_author}");
        Console.WriteLine($"Video Duration: {_duration} seconds");
        Console.WriteLine();

        Console.WriteLine("Comments: ");
        Console.WriteLine();

        foreach (Comment comments in _comments)
        {
            comments.DisplayComments();
        }

        Console.WriteLine($"Number of comments: {TotalComments()}");
        Console.WriteLine("======================================");
    }


}
