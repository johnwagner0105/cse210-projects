public class Video
{
    private string _title, _author;
    private int _lenght;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int lenght)
    {
        _title = title;
        _author = author;
        _lenght = lenght;
    }
    public void AddComment(string name, string text)
    {
        Comment comment = new Comment(name, text);
        _comments.Add(comment);
    }
    public int NumberOfComments()
    {
        return _comments.Count();
    }
    public void DisplayVideos()
    {
        Console.WriteLine($"{_title} by {_author} ({_lenght} seconds)");
        Console.WriteLine($"Comments ({NumberOfComments()})");
        foreach (Comment comment in _comments)
        {
            comment.DisplayComment();
        }
        Console.WriteLine();
    }
}