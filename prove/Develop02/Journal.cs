using System;
using System.IO; 
using System.Collections.Generic;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            int characterCount = entry._entryText.Length;
            Console.Write(entry._date);
            Console.Write(" - ");
            Console.WriteLine(entry._promptText);
            Console.Write(entry._entryText);   
            Console.Write($"   ({characterCount} characters)\n\n");
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                int characterCount = entry._entryText.Length;
                outputFile.Write(entry._date);
                outputFile.WriteLine(entry._promptText);
                outputFile.Write(entry._entryText);   
                outputFile.Write($"   ({characterCount} characters)\n\n");
            }
        }
    }

    public void LoadFromFile(string file)
    {
        List<string> D = new List<string>();
        List<string> P = new List<string>();
        List<string> E = new List<string>();
        string[] lines = System.IO.File.ReadAllLines(file);
        foreach (string line in lines)
        {
            string[] parts1 = line.Split('-');
            if (parts1.Length == 2)
            {
                string date = parts1[0].Trim();
                D.Add(date);
                string promptText = parts1[1].Trim();
                P.Add(promptText);
            }

            string[] parts2 = line.Split("   ");
                Console.WriteLine(parts2.Length);
                if (parts2.Length == 2)
                {
                    string entryText = parts2[0];
                    E.Add(entryText);
                }
        }

        for (int i = 0; i < D.Count; i++)
        {
            Entry entry = new Entry();
            entry._date = D[i];
            entry._promptText = P[i];
            entry._entryText = E[i];
            AddEntry(entry);
        }
    }
}