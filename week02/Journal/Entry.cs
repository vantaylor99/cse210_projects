using System.Runtime.CompilerServices;

public class Entry
{
    // Primary function of the Entry class is to create a format for entries.



    // Variables used in class.
    public string _date;
    public string _prompt;
    public string _journalEntry;



    public Entry() { }
    public Entry(string inputDate, string inputPrompt, string inputJournalEntry)
    {
        _date = inputDate;
        _prompt = inputPrompt;
        _journalEntry = inputJournalEntry;
    }


    public void DisplayEntry()
    {
        // Format for journal entries 
        Console.WriteLine();
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine();
        Console.WriteLine($"Response: {_journalEntry}");
        Console.WriteLine();
    }


}