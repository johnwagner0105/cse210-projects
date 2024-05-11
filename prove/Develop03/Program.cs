using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        string text = "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.";
        string[] numberOfWords = text.Split(" ");
        Scripture scripture = new Scripture(reference, text);
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Random rnd = new Random();

        Console.WriteLine();
        Console.WriteLine("Press Enter to continue or type 'quit' to finish:");
        string option = Console.ReadLine();

        while (option.ToLower() != "quit" && scripture.IsCompletelyHidden() == false)
        {
            for (int i = 0; i < 3; i++)
            {
                int RandomNumber = rnd.Next(numberOfWords.Length);
                bool wordHidden = scripture.HideRandomWord(RandomNumber);
                while (wordHidden == false)
                {
                    if (scripture.IsCompletelyHidden() == true)
                    {
                        break;
                    }
                    RandomNumber = rnd.Next(numberOfWords.Length);
                    wordHidden = scripture.HideRandomWord(RandomNumber);
                }
            }
            // scripture.IsCompletelyHidden();
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press Enter to continue or type 'quit' to finish:");
            option = Console.ReadLine();
        }
    }


}