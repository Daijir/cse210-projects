using System.IO; 

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;
    private int _level;

    public GoalManager()
    {
       
    }

    public void Start()
    {
        while (true)
        {
            DisplayPlayerInfo();
            // Menu
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");

            string sinput1 = Console.ReadLine();
            int input1 = int.Parse(sinput1);

            if (input1 == 1)
            {
                Console.WriteLine("The types of Goals are:");
                Console.WriteLine("  1. Simple Goal");
                Console.WriteLine("  2. Eternal Goal");
                Console.WriteLine("  3. Checklist Goal");   
                Console.Write("Which type of goal would you like to create? ");

                string sinput2 = Console.ReadLine();
                int input2 = int.Parse(sinput2);

                CreateGoal(input2);
            }

            else if (input1 == 2)
            {
                ListGoalDetails();
            }

            else if (input1 == 3)
            {
                SaveGoals();
            }

            else if (input1 == 4)
            {
                LoadGoals();
            }

            else if (input1 == 5)
            {
                RecordEvent();
            }

            else if (input1 == 6)
            {
                break;
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nYou have {_score} points.");
        Console.WriteLine($"Your level is {_level}.\n");
    }

    public void ListGoalNames()
    {
        Console.WriteLine("The goals are:");
        int i = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{i}. {goal._shortName}");
            i++;
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("The goals are:");
        int i = 1;
        foreach (Goal goal in _goals)
        {
            if (goal is SimpleGoal || goal is EternalGoal)
            {
                Console.WriteLine($"{i}. [{(goal.IsComplete() ? "X" : " ")}] {goal._shortName} ({goal._description})");
            }
            else if (goal is ChecklistGoal)
            {
                Console.Write($"{i}. [{(goal.IsComplete() ? "X" : " ")}] {goal._shortName} ({goal._description}) ");
                Console.WriteLine(goal.GetDetailsString());
            }
            i++;
        }
    }

    public void CreateGoal(int input2)
    {
         Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        string points = Console.ReadLine();

        switch (input2)
        {
            case 1:
                SimpleGoal sg = new SimpleGoal(name, description, points);
                _goals.Add(sg);
                break;
            case 2:
                EternalGoal eg = new EternalGoal(name, description, points);
                _goals.Add(eg);
                break;
            case 3:
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                string target = Console.ReadLine();
                Console.Write("What is the bonus for accomplishing it that many times? ");
                string bonus = Console.ReadLine();

                ChecklistGoal cg = new ChecklistGoal(name, description, points, target, bonus);
                _goals.Add(cg);
                break;
            default:
                Console.WriteLine("Invalid goal type");
                break;
        }
    }

    public void RecordEvent()
    {
        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        string sinput = Console.ReadLine();
        int input = int.Parse(sinput);
        int i = input - 1;
        _goals[i].RecordEvent();
        int earnedPoint = int.Parse(_goals[i]._points);

        if (_goals[i] is ChecklistGoal && _goals[i].IsComplete())
        {
            earnedPoint += (_goals[i] as ChecklistGoal)._bonus;
        }

        Console.WriteLine($"Congratulations! You earned {earnedPoint} points!");
        _score += earnedPoint;

        while (_score >= 100)
        {
            _level ++;
            _score -= 100;
            ShowSpinner(2);
            Console.WriteLine($"Congratulations! now you're level {_level}!");

        }

        Console.WriteLine($"You now have {_score} points.");
    }

    public void SaveGoals()
    {
        Console.WriteLine("What is the file name for the goal file?");
        string file = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals()
    {
        Console.WriteLine("What is the file name for the goal file?");
        string file = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(file);
        foreach (string line in lines)
        {
            if (!line.Contains(":"))
            {
                continue;
            }
            string[] goalInfo = line.Split(':');
            string goalType = goalInfo[0];
            Console.WriteLine(goalInfo[1]); 
            string[] goalDetails = goalInfo[1].Split(','); 

            string name = goalDetails[0]; 
            string description = goalDetails[1]; 
            string points = goalDetails[2];

            if (goalType == "SimpleGoal")
            {
                bool isComplete = bool.Parse(goalDetails[3]);

                SimpleGoal sg = new SimpleGoal(name, description, points);
                sg._isComplete = isComplete; 
                _goals.Add(sg);
            }

            else if (goalType == "EternalGoal")
            {
                EternalGoal eg = new EternalGoal(name, description, points);
                _goals.Add(eg);
            }

            else if (goalType == "ChecklistGoal")
            {
                string bonus = goalDetails[3];
                string target = goalDetails[4];
                int amountCompleted = int.Parse(goalDetails[5]);
                ChecklistGoal cg = new ChecklistGoal(name, description, points, target, bonus);
                cg._amountCompleted += amountCompleted;
                _goals.Add(cg);
            }
        }
    }

    public void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b \b");

            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b \b"); 

            Console.Write("-");
            Thread.Sleep(250);
            Console.Write("\b \b"); 

            Console.Write("\\");
            Thread.Sleep(250);
            Console.Write("\b \b");
        }
    }
}