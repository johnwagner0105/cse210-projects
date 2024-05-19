public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {

    }

    public void Run()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(getDuration());
        Console.WriteLine("Get ready...");
        ShowSpinner(1);
        while (DateTime.Now < endTime)
        {

            Console.WriteLine("Breathe in...");
            ShowCountDown(5);
            Console.WriteLine("Now Breathe out...");
            ShowCountDown(5);
        }
        ShowSpinner(1);
    }
}