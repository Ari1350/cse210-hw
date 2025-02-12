using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "Breathe in and out to relax.", 30) { }

    public void Run()
    {
        DisplayStartingMessage();
        for (int i = 0; i < _duration / 10; i++)
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(5);
            Console.WriteLine("Breathe out...");
            ShowCountDown(5);
        }
        DisplayEndingMessage();
    }
}
