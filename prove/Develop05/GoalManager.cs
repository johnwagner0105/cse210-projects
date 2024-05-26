using System.Runtime.InteropServices;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score = 0;

    public GoalManager()
    {

    }

    public void Start()
    {
        string option;
        do
        {

            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.WriteLine("Select a choice from the Menu: ");
            option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    ListGoalNames();
                    break;
                case "3":
                    saveGoals();
                    break;
                case "4":
                    loadGoals();
                    break;
                case "5":
                    RecordEvent();
                    break;

            }
        } while (option != "6");
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points");
    }

    public void ListGoalNames()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
        Console.WriteLine("Which goal did you accomplish? ");
    }

    public void ListGoalDetails()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void CreateGoal()
    {
        string option;
        Console.WriteLine("The types of goals are: ");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine("Which type of goal would you like to create? ");
        option = Console.ReadLine();
        string shortName, description;
        int points, target, bonus;
        switch (option)

        {
            case "1":
                Console.WriteLine("What is the name of your goal? ");
                shortName = Console.ReadLine();
                Console.WriteLine("What is the short description of it? ");
                description = Console.ReadLine();
                Console.WriteLine("What is the amount of points associated with this goal? ");
                points = Convert.ToInt32(Console.ReadLine());
                SimpleGoal simpleGoal = new SimpleGoal(shortName, description, points);
                _goals.Add(simpleGoal);
                break;
            case "2":
                Console.WriteLine("What is the name of your goal? ");
                shortName = Console.ReadLine();
                Console.WriteLine("What is the short description of it? ");
                description = Console.ReadLine();
                Console.WriteLine("What is the amount of points associated with this goal? ");
                points = Convert.ToInt32(Console.ReadLine());
                EternalGoal eternalGoal = new EternalGoal(shortName, description, points);
                _goals.Add(eternalGoal);
                break;
            case "3":
                Console.WriteLine("What is the name of your goal? ");
                shortName = Console.ReadLine();
                Console.WriteLine("What is the short description of it? ");
                description = Console.ReadLine();
                Console.WriteLine("What is the amount of points associated with this goal? ");
                points = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
                target = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Whats is the bonus for accomplishing it that many times? ");
                bonus = Convert.ToInt32(Console.ReadLine());
                ChecklistGoal checklistGoal = new ChecklistGoal(target, bonus, shortName, description, points);
                _goals.Add(checklistGoal);
                break;
        }
    }

    public void RecordEvent()
    {
        Console.WriteLine("The goals are: ");
        ListGoalNames();
        int option = Convert.ToInt32(Console.ReadLine());
        _goals[option - 1].RecordEvent();

    }

    public void saveGoals()
    {
        Console.WriteLine("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {

            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine($"{goal.GetStringRepresentation()}");
            }
        }

    }

    public void loadGoals()
    {
        string filename = "myFile.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            string goalType = parts[0];
            if (goalType == "SimpleGoal")
            {

                string shortName = parts[1];
                string description = parts[2];
                string points = parts[3];
                string complete = parts[4];

                SimpleGoal newGoal = new SimpleGoal(shortName, description, Convert.ToInt32(points));
                _goals.Add(newGoal);
            }
            else if (goalType == "EternalGoal")
            {
                string shortName = parts[1];
                string description = parts[2];
                string points = parts[3];


                EternalGoal newGoal = new EternalGoal(shortName, description, Convert.ToInt32(points));
                _goals.Add(newGoal);
            }
            else if (goalType == "checklistGoal")
            {
                string shortName = parts[1];
                string description = parts[2];
                string points = parts[3];
                string completed = parts[4];
                string target = parts[5];
                string bonus = parts[6];


                ChecklistGoal newGoal = new ChecklistGoal(Convert.ToInt32(target), Convert.ToInt32(bonus), shortName, description, Convert.ToInt32(points));
                _goals.Add(newGoal);
            }
        }
    }
}