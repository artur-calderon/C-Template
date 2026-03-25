public class Comment
{
    string _author;
    string _commentText;

    public void SetComment(string author, string commentText)
    {
        _commentText = commentText;
        _author = author;
    }

    public void DisplayComments()
    {
        Console.WriteLine($"{_author}: {_commentText}");
    }

}