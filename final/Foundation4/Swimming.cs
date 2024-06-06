public class Swimming : Event
{
    private int _laps;

    public Swimming(string date, double minutes, int laps) : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000;
    }

    public override double GetSpeed()
    {
        return Math.Round(((GetDistance() / GetMinutes()) * 60), 3);
    }

    public override double GetPace()
    {
        return GetMinutes() / GetSpeed();
    }



}