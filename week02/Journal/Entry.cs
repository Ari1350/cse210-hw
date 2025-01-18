public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public Entry (string prompt, string answer)
    {
        _date = DateTime.Now.ToShortDateString();
        _promptText = prompt;
        _entryText = answer;
    }

    public void Display()
    {
        Console.WriteLine($"{_date} - Prompt: {_promptText}\n{_entryText}\n");
    }
}