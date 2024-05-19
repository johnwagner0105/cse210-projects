public class ReflectionActivity : Activity
{
    private List<string> _prompts = ["Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."];
    private List<string> _questions = ["Why was this experience meaningful to you?", "Why was this experience meaningful to you?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"];
    public ReflectionActivity(string name, string description, int duration) : base(name, description, duration)
    {

    }

    public string GetRandomPrompt()
    {
        Random randomIndex = new Random();
        int index = randomIndex.Next(_prompts.Count);
        string randomPrompt = _prompts[index];
        return randomPrompt;
    }

    public string GetRandomQuestion()
    {
        Random randomIndex = new Random();
        int index = randomIndex.Next(_questions.Count);
        string randomQuestion = _questions[index];
        return randomQuestion;
    }
    public void DisplayPrompt()
    {
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"---{GetRandomPrompt()}---");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
    }

    public void DisplayQuestions()
    {
        Console.WriteLine($"{GetRandomQuestion()}");
    }
    public void Run()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(getDuration());
        Console.WriteLine("Get ready...");
        ShowSpinner(1);
        DisplayPrompt();
        ShowCountDown(5);
        while (DateTime.Now < endTime)
        {
            DisplayQuestions();
            ShowSpinner(1);
        }
        ShowSpinner(1);
    }
}