public class ListingActivity : Activity
{
    private List<string> _prompts = ["Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"];
    private List<string> _listFromUser = new List<string>();
    private int _count = 0;
    public ListingActivity(string name, string description, int duration) : base(name, description, duration)
    {

    }

    public void GetRandomPrompt()
    {
        Random randomIndex = new Random();
        int index = randomIndex.Next(_prompts.Count);
        string randomPrompt = _prompts[index];
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($"---{randomPrompt}---");
        Console.WriteLine("You may begin in: ");
    }

    public List<string> GetListFromUser()
    {
        _listFromUser.Add(Console.ReadLine());
        _count += 1;
        return _listFromUser;
    }

    public void Run()
    {
        GetRandomPrompt();
        ShowCountDown(5);
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(getDuration());
        while (DateTime.Now < endTime)
        {
            GetListFromUser();
        }
        Console.WriteLine($"You listed {_count} items!");

    }

}