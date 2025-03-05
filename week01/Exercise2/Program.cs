using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string gradeFromUser = Console.ReadLine();
        float grade = float.Parse(gradeFromUser);
        string lettergrade = "";
        string symbol = "";



        // Symbol code
        float plusOrMinus = grade % 10;

        if (plusOrMinus >= 7)
        {
            symbol = "+";
        }
        if (plusOrMinus <= 3)
        {
            symbol = "-";
        }


        // Letter Grade Code
        if (grade >= 50 && grade < 60)
        {
            lettergrade = ("F");
        }
        if (grade >= 60 && grade < 70)
        {
            lettergrade = ("D");
        }
        if (grade >= 70 && grade < 80)
        {
            lettergrade = ("C");
        }
        if (grade >= 80 && grade < 90)
        {
            lettergrade = ("B");
        }
        if (grade >= 90)
        {
            lettergrade = ("A");
        }


        // Code to get rid of anomalies (A+, F-, etc)
        if (lettergrade == "A" && symbol == "+")
        {
            symbol = "";
        }
        if (lettergrade == "F")
        {
            symbol = "";
        }


        // A or an code
        string aOrAn = "a";
        if (lettergrade == "A" | lettergrade == "F")
        {
            aOrAn = "an";
        }


        // Print results
        Console.WriteLine($"Your grade is {aOrAn} {lettergrade}{symbol}. ");
        if (grade > 70)
        {
            Console.WriteLine("Congradulations! You passed the class!");
        }
        else
        {
            Console.WriteLine("Sorry! You didn't pass, better luck next time! ");
        }
    }
}