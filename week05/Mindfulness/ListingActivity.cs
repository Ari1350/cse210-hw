using System;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string> { "Name a few things you are grateful for:", "List your favorite hobbies:" };
    private int _count;

    public ListingActivity() : base("Listing Activity", "List items based on the given prompts.", 30) { }

    public void Run()
    {
        DisplayStartingMessage();
        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);
        List<string> userInput = GetListFromUser();
        _count = userInput.Count;

        Console.WriteLine($"You listed {_count} items:");
        foreach (var item in userInput)
        {
            Console.WriteLine($"- {item}");
        }
        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        return _prompts[random.Next(_prompts.Count)];
    }

    private List<string> GetListFromUser()
    {
        Console.WriteLine("Start listing (type 'done' to finish):");
        List<string> items = new List<string>();
        while (true)
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "done")
                break;
            items.Add(input);
        }
        return items;
    }
}
