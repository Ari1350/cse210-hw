class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>
        {
            new SimpleGoal("Run 5km", "Complete a 5km run", 50),
            new EternalGoal("Daily Meditation", "Meditate for 10 minutes daily", 10),
            new ChecklistGoal("Read Books", "Read 5 books this month", 20, 5, 50)
        };
        _score = 0;
    }

    public void Start()
    {
        string choice;
        do
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Show Score");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine($"Current Score: {_score}");
                    break;
                case "2":
                    ListGoals();
                    break;
                case "3":
                    RecordEvent();
                    break;
            }
        } while (choice != "4");
    }

    private void ListGoals()
    {
        Console.WriteLine("\nGoals:");
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    private void RecordEvent()
    {
        Console.WriteLine("\nSelect a goal to record:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }

        int choice = int.Parse(Console.ReadLine()) - 1;
        if (choice >= 0 && choice < _goals.Count)
        {
            _goals[choice].RecordEvent();
            _score += _goals[choice].Points;
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }
    }
}
