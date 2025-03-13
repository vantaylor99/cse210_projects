using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;

class Program
{
    public int userInput = 0;
    public List<Entry> myEntries = new List<Entry>();
    static void Main(string[] args)
    {

        Journal myJournal = new Journal();

        myJournal.EnsureFileExists();

        myJournal.Load(false);

        int userInput = 0;


        while (userInput != 5)
        {
            // User input Menu selections
            Console.WriteLine("Please select one of the following choices and then hit enter. ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit ");
            Console.WriteLine();
            Console.Write("Selection: ");
            userInput = int.Parse(Console.ReadLine());


            if (userInput == 1)
            {
                Console.WriteLine("Write. ");
                Console.WriteLine();
                myJournal.WriteEntry();
            }
            if (userInput == 2)
            {
                Console.WriteLine("Display");
                myJournal.DisplayAllEntries();
                Console.WriteLine();
            }
            if (userInput == 3)
            {
                Console.WriteLine("Load");
                myJournal.Load(true);
                Console.WriteLine();
            }
            if (userInput == 4)
            {
                Console.WriteLine("Save");
                myJournal.SaveToFile();
                Console.WriteLine();
            }
            if (userInput == 5)
            {
                Console.WriteLine("Thank you for recording in your journal!");
                Console.WriteLine();
            }

        }
    }

}