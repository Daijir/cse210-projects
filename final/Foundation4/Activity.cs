public abstract class Activity
{
    private string _date;
    private int _minutes;

    public Activity(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }  

    public virtual int GetMinutes()
    {
        return _minutes;
    }

    public virtual double GetDistance()
    {
        return 0.0;
    }

    public virtual double GetSpeed()
    {
        return (GetDistance() / _minutes) * 60;
    }

    public virtual double GetPace()
    {
        return _minutes / GetDistance();
    }

    public virtual string GetSummary()
    {
        return $"{_date} {GetType().Name} ({GetMinutes()} min)- Distance {GetDistance()} kilometer, Speed {GetSpeed()} kph, Pace: {GetPace()} min per kilometer";
    }
}