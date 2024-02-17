public class Reception : Event
{
    private string _email;
    public Reception(string title, string description, string date, string time, Address address, string email) 
        : base (title, description, date, time, address)
    {
        _email = email;
    }

    public override string GetFullDetails()
    {
        return base.GetFullDetails() + $"\nType of Event: Reception\nRSVP Email: {_email}";
 
    }
}