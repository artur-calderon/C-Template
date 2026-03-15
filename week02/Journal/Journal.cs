using System.ComponentModel;
using System.IO;
public class Journal
{
    List<Entry> _entries = new List<Entry>();

    public void AddEntry(string entryText, string promptText)
    {
        Entry entry = new Entry();
        entry._entryText = entryText;
        entry._promptText = promptText;

        _entries.Add(entry);

    }

    public void DisplayAll()
    {
        foreach (Entry entries in _entries)
        {
            entries.Display();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entries in _entries)
            {
                outputFile.WriteLine($"{entries._date},{entries._promptText},{entries._entryText}");
            }
        }
    }

    public void LoadFromFile(string file)
    {
        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split(',');

            Entry entry = new Entry();
            entry._date = parts[0];
            entry._promptText = parts[1];
            entry._entryText = parts[2];

            _entries.Add(entry);
        }
    }

}
