public abstract class Event
{
    private string _date;
    private double _minutes, _distance, _speed;
    private int _laps;


    public Event(string date, double minutes)
    {
        _date = date;
        _minutes = minutes;
    }
    public double GetMinutes()
    {
        return _minutes;
    }
    public void SetDistance(double distance)
    {
        _distance = distance;
    }
    public void SetSpeed(double speed)
    {
        _speed = speed;
    }
    public void SetLaps(int laps)
    {
        _laps = laps;
    }

    public string GetActivitySummary()
    {
        return $"{_date} {this.GetType().Name} ({_minutes} min) - Distance: {GetDistance()} km, Speed: {GetSpeed()} kmph, Pace: {GetPace()} min per kilometer";
    }
    public virtual double GetDistance()
    {
        return _distance;
    }
    public virtual double GetSpeed()
    {
        return _speed;
    }
    public abstract double GetPace();
}