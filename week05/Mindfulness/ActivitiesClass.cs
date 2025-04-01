using System.Diagnostics;

public class Activities
{


    protected string _ActivityName = "";
    private string _destription = "";
    protected int _durationInSeconds = 0;




    public void SetActivityName(string input)
    {
        _ActivityName = input;
    }

    protected int _durationInMiliseconds(int _durationInSeconds)
    {
        return _durationInSeconds * 1000;
    }


    protected int _durationPerActivity(int _durationInSeconds)
    {
        return _durationInSeconds * 1000 / 2;
    }



    public void DisplayWelcomeMessage(string _ActivityName)
    {
        Console.WriteLine($"Welcome to the {_ActivityName} activity.\n\n");
        Console.WriteLine(DisplayActivityDescription(_ActivityName));
        Console.WriteLine();
        SessionLength();
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSleepAnimation(3);

    }

    public string DisplayActivityDescription(string _ActivityName)
    {
        if (_ActivityName == "Reflecting")
        {
            _destription = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power y ou have and how you cna use it in other aspects of your life. ";
        }

        if (_ActivityName == "Breathing")
        {
            _destription = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing. ";
        }

        if (_ActivityName == "Listing")
        {
            _destription = "This activity will help you reflect on the good things in your life by having you list out as many things as you can in a certain area.";
        }
        return _destription;
    }

    public void DisplayEndingMessage(string activity, int duration)
    {
        Console.WriteLine("\n\nWell done!");
        ShowSleepAnimation(3);
        Console.WriteLine($"\nThank you for doing the {activity} activity!");
        ShowSleepAnimation(3);
        Console.WriteLine($"\nYou have completed another {duration} seconds of the {activity} activity.");
        ShowSleepAnimation(3);
        Console.Clear();

    }


    public void SessionLength()
    {
        Console.Write("How long, in seconds would you like for your session? ");
        string seconds = Console.ReadLine();
        _durationInSeconds = int.Parse(seconds);
    }




    public void ShowSleepAnimation(int seconds)
    {
        Console.CursorVisible = false;
        for (int i = 0; i < seconds; i++)
        {

            Console.Write($"(*.*)");
            Thread.Sleep(100);
            Console.Write("\r");

            Console.Write($"(*o*)");
            Thread.Sleep(105);
            Console.Write("\r");

            Console.Write($"(*O*)");
            Thread.Sleep(125);
            Console.Write("\r");

            Console.Write($"(*Q*)");
            Thread.Sleep(300);
            Console.Write("\r");

            Console.Write($"(*O*)");
            Thread.Sleep(125);
            Console.Write("\r");

            Console.Write($"(*o*)");
            Thread.Sleep(105);
            Console.Write("\r");

            Console.Write($"(*.*)");
            Thread.Sleep(100);
            Console.Write("\r");


        }
        Console.Write("\r     ");
        Console.CursorVisible = true;

    }

    public void ShowNumberedCountdown(int inputI)
    {
        Console.CursorVisible = false;
        for (int i = inputI; i > 0; i--)
        {

            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b");
        }
        Console.Write(" \b\b");
        Console.Write("\a");
        Console.CursorVisible = true;
    }



}