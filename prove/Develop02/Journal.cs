using System.IO;

public class Journal
{
    List<Entry> entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {


        entries.Add(entry);

    }

    public void DisplayAll()
    {
        foreach (Entry entry in entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        if (File.Exists(file))
        {

            FileInfo fileInfo = new FileInfo(file);
            if (fileInfo.Length == 0)
            {
                using (StreamWriter outputFile = new StreamWriter(file))
                {
                    foreach (Entry entry in entries)
                    {
                        outputFile.WriteLine(string.Join(",", [entry._date, entry._entryText, entry._promptText]));
                    }
                }
            }
            else
            {
                using (StreamWriter outputFile = File.AppendText(file))
                {
                    foreach (Entry entry in entries)
                    {
                        outputFile.WriteLine(string.Join(",", [entry._date, entry._entryText, entry._promptText]));
                    }
                }
            }
        }
        else
        {
            using (StreamWriter outputFile = new StreamWriter(file))
            {
                foreach (Entry entry in entries)
                {
                    outputFile.WriteLine(string.Join(",", [entry._date, entry._entryText, entry._promptText]));
                }
            }
        }

        entries = new List<Entry>();
    }

    public void LoadFromFile(string file)
    {
        string[] lines = System.IO.File.ReadAllLines(file);
        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            Entry entry = new Entry();
            entry._date = parts[0];
            entry._entryText = parts[1];
            entry._promptText = parts[2];

            entries.Add(entry);
        }
    }

    public void DeleteFileContent(string file)
    {
        File.WriteAllText(file, string.Empty);
    }
}