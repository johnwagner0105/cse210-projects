public abstract class Goal
{
    private string _shortName, _description;
    private int _points;

    public Goal(string shortName, string description, int points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }

    public int getPoints()
    {
        return _points;
    }
    public string getShortName()
    {
        return _shortName;
    }
    public string getDescription()
    {
        return _description;
    }
    public abstract int RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetStringRepresentation();
    public virtual string GetDetailsString()
    {
        if (IsComplete())
        {

            return $"[X] {_shortName} ({_description})";
        }
        else
        {
            return $"[ ] {_shortName} ({_description})";
        }
    }
}