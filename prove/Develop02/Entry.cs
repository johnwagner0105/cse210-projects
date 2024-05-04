public class Entry
{
    public string _promptText, _entryText;
    public string _date = DateTime.Now.ToShortDateString();

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine($"{_entryText}");
    }
}