public class SimpleGoal : Goal
{
    private bool _isComplete = false;

    public SimpleGoal(string shortName, string description, int points) : base(shortName, description, points)
    {

    }
    public override bool IsComplete()
    {
        return _isComplete = true;
    }

    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            IsComplete();
            return getPoints();
        }
        else
        {
            Console.Write("The task was already completed");
            return 0;
        }
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal|{getShortName()}|{getDescription()}|{getPoints()}|{_isComplete}";
    }
}