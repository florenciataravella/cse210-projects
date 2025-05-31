using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Journal
{
    List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);

    }
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
    public void LoadFromFile(string file)

    {
        _entries.Clear();
        string[] lines = System.IO.File.ReadAllLines(file);
        int i = 0;

        foreach (string line in lines)
        {
            string[] parts = line.Split("&");
            i = line.Count(c => c == '&');
            if (i == 2)
            {
                string journalDate = parts[0];
                string journalPrompt = parts[1];
                string journalWrite = parts[2];
                string displayJournal = journalDate + " " + "-" + journalPrompt + Environment.NewLine + journalWrite;
                Console.WriteLine(displayJournal);
            }
            
            int f = i % 3;

            while (f == 0)
            {
                string newDayDate = parts[i];
                string newDayPrompt = parts[i + 1];
                string newDayWrite = parts[i + 2];
                string displayNewDay = newDayDate + " " + "-" + newDayPrompt + Environment.NewLine + newDayWrite;
                Console.WriteLine(displayNewDay);
            }
        }
    }
                
    public void SaveToFile(string file)

    {
        
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)

                outputFile.WriteLine($"{entry.time()} & {entry._promptText} & {entry._entryText}");
        }
    }

}




    
