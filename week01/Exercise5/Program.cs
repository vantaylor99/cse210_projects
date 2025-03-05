using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        DisplayMessage();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squaredNumber = SquareNumbers(userNumber);

        DisplayResult(userName, squaredNumber);

    }

    static void DisplayMessage()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("What is your name? ");
        string userInput = Console.ReadLine();

        return userInput;
    }

    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number? ");
        int userNumber = int.Parse(Console.ReadLine());

        return userNumber;
    }

    static int SquareNumbers(int number)
    {
        int squared = number * number;

        return squared;
    }
    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"Hello, {name}, your number squared is {square}. ");
    }


}