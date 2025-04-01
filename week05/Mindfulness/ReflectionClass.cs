using System.Diagnostics;

public class Reflection : Activities
{
    private List<string> _prompts = new List<string>
    {   "Think about a time when you chose to repent.",
        "Think of a time when you demonstrated your love for God through obedience",
        "Think of a time when you overcame a trial or an addiction.",
        "Think of a time when you showed God you were serious about something."
    };




    private List<string> _questions = new List<string>
    {
        "What made this experience significant in your spiritual journey?",
        "How did you feel God's presence or guidance during this time?",
        "What personal change came as a result of this experience?",
        "How did this moment strengthen your relationship with Jesus Christ?",
        "What emotions did you feel during and after the experience?",
        "What helped you make the decision to act the way you did?",
        "What did you learn about God through this experience?",
        "How did this experience increase your faith or trust in Him?",
        "Would you respond differently if you had the chance to go through it again? Why or why not?",
        "How can this experience help you in future decisions or trials?"
    };

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    private string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        return _questions[index];
    }



    private void ReflectionActivity()
    {
        DisplayWelcomeMessage(_ActivityName);
        string prompt = GetRandomPrompt();
        Console.WriteLine($"\n---{prompt}---");
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("\nNow Ponder on each of the following questions and how they relate to this experience.");
        Console.Write("You may begin in: ");
        ShowNumberedCountdown(5);
        Console.Clear();





        Console.WriteLine(prompt);
        string question = GetRandomQuestion();
        Console.WriteLine($"> {question} ");
        ShowSleepAnimation(_durationInSeconds);
        question = GetRandomQuestion();
        Console.WriteLine($"\n> {question} ");
        ShowSleepAnimation(_durationInSeconds);



        DisplayEndingMessage("Reflection", _durationInSeconds);
    }


    public void RunReflectionActivity()
    {
        ReflectionActivity();
    }
}