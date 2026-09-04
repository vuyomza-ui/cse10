using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        // Add the new entry to the list of entries
        entries.Add(newEntry);
    }
    
    public void DisplayAll()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("There are no entries in your journal.");
            return;            
        }

        foreach (Entry entry in entries)
        {
            entry.Display(); 
        }   
    }

    public void SaveToFile(string filename)
    {

        // Save the list of entries to a file
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in entries)
            {
                outputFile.WriteLine(entry.GetFileString());
            }
        }
    }    

    public void LoadFromFile(string filename)
    {
        // Replace the current journal with the loaded journal
        entries.Clear();

        using (StreamReader inputFile = new StreamReader(filename))
        {
            string line;

            while ((line = inputFile.ReadLine()) != null)
            {
                string[] parts = line.Split('|');

                if (parts.Length >= 3)
                {
                    string date = parts[0];
                    string prompt = parts[1];
                    string response = parts[2];

                    Entry entry = new Entry(date, prompt, response);
                    
                    entries.Add(entry);
                }
            }
        }
    }
}