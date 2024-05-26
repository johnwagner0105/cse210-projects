public class ChecklistGoal : Goal
{
    private int _amountCompleted, _target, _bonus;

    public ChecklistGoal(int target, int bonus, string shortName, string description, int points) : base(shortName, description, points)
    {
        _target = target;
        _bonus = bonus;
    }
    public override bool IsComplete()
    {
        return true;
    }
    public override int RecordEvent()
    {

        if (_amountCompleted == _target)
        {
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
        return $"ChecklistGoal|{getShortName()}|{getDescription()}|{getPoints()}|{_amountCompleted}|{_target}|{_bonus}";
    }

    public override string GetDetailsString()
    {
        if (IsComplete())
        {

            return $"[X] {getShortName()} ({getDescription()}) -- Currently completed: {_amountCompleted}/{_target}";
        }
        else
        {
            return $"[ ] {getShortName()} ({getDescription()}) -- Currently completed: {_amountCompleted}/{_target}";
        }
    }
}