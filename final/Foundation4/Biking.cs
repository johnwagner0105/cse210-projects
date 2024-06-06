public class Biking : Event
{

    public Biking(string date, double minutes, double speed) : base(date, minutes)
    {
        SetSpeed(speed);
    }

    public override double GetDistance()
    {
        return GetMinutes() / GetPace();
    }
    public override double GetPace()
    {
        return GetMinutes() / GetSpeed();
    }



}