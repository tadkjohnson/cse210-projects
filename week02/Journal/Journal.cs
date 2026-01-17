using System;
using System.Collections.Generic;
using System.IO;


public class Journal
{
    private List<dailyEntry> _entries = new List<dailyEntry>();
    public void AddEntry(dailyEntry entry)
    {
        _entries.Add(entry);

    }
    public void DisplayEntries()
    {
        foreach (dailyEntry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string myJournal)
    {
        using (StreamWriter write = new StreamWriter(myJournal))
        {
            foreach (dailyEntry entry in _entries)
            {
                write.WriteLine(entry.ToFileString());

            }
        }
    }

    public void LoadFromFile(string filename)
    {
        _entries.Clear();

        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            dailyEntry entry = dailyEntry.FromFileString(line);
            _entries.Add(entry);
        }
    }
}

