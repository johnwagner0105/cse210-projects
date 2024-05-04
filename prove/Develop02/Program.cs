using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {

        string file, option;
        Journal journal = new Journal();

        do
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Delete content in file");
            Console.WriteLine("6. Quit");
            Console.Write("What would you like to do?");
            option = Console.ReadLine();
            switch (option)
            {

                case "1":
                    Entry entry = new Entry();
                    PromptGenerator question = new PromptGenerator();
                    entry._promptText = question.GetRandomPrompt();
                    Console.WriteLine(entry._promptText);
                    entry._entryText = Console.ReadLine();

                    journal.AddEntry(entry);
                    break;
                case "2":
                    journal.DisplayAll();
                    break;
                case "3":
                    Console.Write("What is the filename?");
                    file = Console.ReadLine();
                    journal.LoadFromFile(file);
                    break;
                case "4":
                    Console.Write("What is the filename?");
                    file = Console.ReadLine();
                    journal.SaveToFile(file);
                    break;
                case "5":
                    Console.Write("What is the filename?");
                    file = Console.ReadLine();
                    journal.DeleteFileContent(file);
                    break;
            }

        } while (option != "6");
    }
}