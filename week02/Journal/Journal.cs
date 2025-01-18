public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
         _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
       foreach (var entry in _entries)
       {
        entry.Display();
       }
    }
    public void SaveToFile (string file)
    {
         string filename = "journal.txt";
         using (StreamWriter outputFile = new StreamWriter (filename))
         {
            foreach (var entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
            }
         }
    }

    public void LoadFromFile(string file)
    {
        string[] lines = File.ReadAllLines(file);
        _entries.Clear();

        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            if (parts.Length == 3)
            {
                Entry loadedEntry = new Entry(parts[1], parts[2])
                {
                    _date = parts[0]
                };
                _entries.Add(loadedEntry);
            }
        }
    }
    
}