public class Video
{
    // track the title, author, and length (in seconds) of the video
    private string _title;
    private string _author;
    private int _length;

    //Each video also has responsibility to store a list of comments
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;

    }

    // Add a comment to _comment list
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    // count comment objects in _comments list
    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    public void DisplayInformation()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} seconds");
        Console.WriteLine($"Number of Comments: {GetNumberOfComments()}");
        Console.WriteLine("Comments:");

        foreach (var comment in _comments)
        {
            Console.WriteLine($" - {comment._commenter}: {comment._text}");
        }
    }

}