public class Running : Event
{

    public Running(string date, double minutes, double distance) : base(date, minutes)
    {
        SetDistance(distance);
    }

    public override double GetSpeed()
    {
        return ((GetDistance() / GetMinutes()) * 60);
    }
    public override double GetPace()
    {
        return GetMinutes() / GetDistance();
    }



}