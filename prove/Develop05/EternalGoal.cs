public class EternalGoal : Goal
{
    public EternalGoal(string shortName, string description, int points) : base(shortName, description, points) { }
    public override bool IsComplete()
    {
        return false;
    }
    public override int RecordEvent()
    {
        return getPoints();

    }
    public override string GetStringRepresentation()
    {
        return $"EternalGoal|{getShortName()}|{getDescription()}|{getPoints()}";
    }

}