public class Bicycle : Activity
{
    private double _speed;
    public Bicycle(string date, int minutes, double speed) : base(date, minutes)
    {
        _speed = speed;
    }  

     public override double GetDistance()
    {
        return _speed * base.GetMinutes() / 60;
    }
}