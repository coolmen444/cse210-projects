public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry) {
        _entries.Add(entry);
    }

    public void SaveJournal()
    {
        Console.Write("What is the filename? ");
            string fileName = Console.ReadLine();
            string filePath = Path.Combine("..", "..", "..", "journals", fileName);

            using (StreamWriter outputFile = new StreamWriter(filePath))
            {
                foreach (Entry entry in this._entries) {
                outputFile.WriteLine($"{entry._date}~|~{entry._prompt}~|~{entry._response}");
                }
            }
    }

    public void LoadJournal()
    {
        Console.Write("What is the filename? ");
        
        string fileName = Console.ReadLine();
        string filePath = Path.Combine("..", "..", "..", "journals", fileName);

        string[] lines = System.IO.File.ReadAllLines(filePath);

        foreach (string line in lines)
        {
            Entry entry = new Entry();
            string[] parts = line.Split("~|~");

            string date = parts[0];
            string prompt = parts[1];
            string response = parts[2];

            entry.SetEntry(prompt, response, date);
            this.AddEntry(entry);

        }
    }

}


