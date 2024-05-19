public class Activity
{
    private string _name, _description;
    private int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }
    public int getDuration()
    {
        return _duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} activity.");
        Console.WriteLine();
        Console.WriteLine($"{_description}");
        Console.WriteLine();
        Console.WriteLine("How Long, in seconds, would you like your session?: ");
        _duration = Convert.ToInt32(Console.ReadLine());
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!");
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the Reflection Activity.");
    }

    public void ShowSpinner(int seconds)
    {
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

        // foreach (string s in animationStrings)
        // {
        //     Console.Write(s);
        //     Thread.Sleep(1000);
        //     Console.Write("/b /b");
        // }
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds * 5);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;

            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }

    }
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}