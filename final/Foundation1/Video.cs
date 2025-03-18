public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _commentList = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void AddComment(string name, string text)
    {
        Comment comment = new Comment(name, text);
        _commentList.Add(comment);
    }

    public void Display()
    {
        Console.WriteLine($"{_title} | {_author} | {_length} seconds | {_commentList.Count} comments");

        foreach (Comment comment in _commentList)
        {
            Console.WriteLine(comment.GetComment());
        }
    }
}