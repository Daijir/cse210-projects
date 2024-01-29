public class WritingAssignment : Assignment
{
    protected string _title;
    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic)
    {
        _title = title;
    }

    public string GetWrtingInformation()
    {
        return $"{_title} by {_studentName}";
    }
}