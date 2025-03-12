using Microsoft.VisualBasic;

public class Journal
{
    // Primary function of the Journal class is to manage saving, loading, and displaying journal entries.


    public string _filename = "journal.txt";
    public List<Entry> myEntries = new List<Entry>();



    public void WriteEntry()
    {
        // Prompts the user for the date, dispalys the prompt, and prompts user for a response.
        // Adds entry into the list myEntries

        Console.WriteLine("Please enter the date: (MM/DD//YYYY)");
        string date = Console.ReadLine();

        string prompt = getRandomPrompt();
        Console.WriteLine($"Your prompt is: {prompt}");
        Console.WriteLine();

        Console.Write("Journal entry: ");
        string response = Console.ReadLine();

        Entry newEntry = new Entry(date, prompt, response);

        myEntries.Add(newEntry);
        Console.WriteLine("Entry added successfully. ");
        Console.WriteLine();
    }




    public string getRandomPrompt()
    {
        // Gets a random index number and then assigns it to a random prompt, 
        // returns prompt with index.

        List<string> prompts = new List<string>
        {
            "What was something good that happened to you today? ",
            "When did you feel the spirit today? If not today, when was the last time you felt the spirit? ",
            "Who was somebody who made a difference in your day today? ",
            "What are some things you did today to demonstrate your love for somebody else? ",
            "How did you see the Lords hand in your life today? ",
            "What was a challenge you faced today and how did you overcome it? ",
            "Who is somebody you served or could have served better today? What would you do differently? ",
            "How did you feel Gods love today? "
        };

        Random random = new Random();

        int index = random.Next(prompts.Count);

        return prompts[index];
    }




    // Displaying / Saving / Loading Entries
    public void DisplayAllEntries()
    {
        foreach (Entry storedEntry in myEntries)
        {
            storedEntry.DisplayEntry();
        }
    }



    // Writing / Saving
    public void SaveToFile()
    {
        // Prompts user for desired filename
        // If file already exists, adds entries to existing file
        // If not creates new file with the userinput as the filename


        Console.Write("Enter a filename to save (e.g. journal.txt): ");
        string userFileName = Console.ReadLine().Trim();

        _filename = userFileName;

        using (StreamWriter outputFile = new StreamWriter(_filename, false))
        {
            foreach (Entry entrySave in myEntries)
            {
                outputFile.WriteLine();
                outputFile.WriteLine($"Date: {entrySave._date}");
                outputFile.WriteLine($"Prompt: {entrySave._prompt}");
                outputFile.WriteLine($"Response: {entrySave._journalEntry}");
                outputFile.WriteLine();
                outputFile.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            }
            Console.WriteLine("File saved.");
        }

    }


    // Reading existing entries
    public List<Entry> ReadFromFile()
    {
        // Reads existing entries and only returns the information from user instead of tags such as "Date: "

        List<Entry> journalEntries = new List<Entry>();

        using (StreamReader inputFile = new StreamReader(_filename))
        {
            string line;
            Entry entry1 = null;

            while ((line = inputFile.ReadLine()) != null)
            {

                if (line.Length > 6)
                {
                    if (line.Substring(0, 6) == "Date: ")
                    {
                        entry1 = new Entry();
                        entry1._date = line.Substring(6, line.Length - 6);
                    }
                    else if (line.Substring(0, 8) == "Prompt: ")
                    {
                        if (entry1 != null)
                            entry1._prompt = line.Substring(8, line.Length - 8);
                    }
                    else if (line.Substring(0, 10) == "Response: ")
                    {
                        if (entry1 != null)

                        {
                            entry1._journalEntry = line.Substring(10, line.Length - 10);
                            journalEntries.Add(entry1);
                        }
                    }
                }

            }
            return journalEntries;
        }

    }

    // Loading existing files
    public void load(bool askForFileName)
    {
        // Prompts user for file name and loads inputed file.
        // If file doesn't exist loops back to the beginning. 
        // Bottom section allows the program to load existing entries 
        // without overwriting old entries. 


        string fileToLoad = _filename;

        if (askForFileName == true)
        {
            {
                Console.Write("What is the file name? ");
                fileToLoad = Console.ReadLine().Trim();
            }

            if (!File.Exists(fileToLoad))
            {
                Console.WriteLine($"Error: File '{fileToLoad}' not found. Please try again.");
                return;
            }

            _filename = fileToLoad;

            List<Entry> loadedEntries = ReadFromFile();


            foreach (Entry entry in loadedEntries)
            {
                if (!myEntries.Exists(e => e._date == entry._date && e._prompt == entry._prompt && e._journalEntry == entry._journalEntry))
                {
                    myEntries.Add(entry);
                }
            }

            Console.WriteLine($"Journal loaded successfully from '{_filename}'.");
            DisplayAllEntries();
        }

        // Code that allows program to open old entries withour overwriting them. 

        if (askForFileName == false)
        {
            _filename = fileToLoad;

            List<Entry> loadedEntries = ReadFromFile();


            // Checks if entry already exists before adding it into .txt file 
            foreach (Entry entry in loadedEntries)
            {
                if (!myEntries.Exists(e => e._date == entry._date && e._prompt == entry._prompt && e._journalEntry == entry._journalEntry))
                {
                    myEntries.Add(entry);
                }
            }
            Console.WriteLine($"Journal loaded successfully from '{_filename}'.");
            Console.WriteLine();
        }
    }

    // Code that checks if journal.txt exists before running program, if not, creates a blank one. 

    public void EnsureFileExhists()
    {
        if (!File.Exists(_filename))
        {
            using (File.Create(_filename)) { }
            Console.WriteLine($"'{_filename}' not found. A blank 'journal.txt' file has been created. ");
        }
    }


}