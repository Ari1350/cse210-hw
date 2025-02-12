using System;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string> { "Think about a time when you overcame a challenge.", "Reflect on a moment of joy in your life." };
    private List<string> _questions = new List<string> { "Why was this experience meaningful?", "What did you learn from it?" };

    public ReflectingActivity() : base("Reflecting Activity", "Reflect on meaningful experiences.", 30) { }

    public void Run()
    {
        DisplayStartingMessage();
        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);

        ShowSpinner(3);
        Console.WriteLine("Now think about the following questions:");

        foreach (string question in _questions)
        {
            Console.WriteLine(question);
            ShowSpinner(5);
        }

        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        return _prompts[random.Next(_prompts.Count)];
    }
}
