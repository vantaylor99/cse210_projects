using System.Diagnostics;

public class Listing : Activities
{

    private List<string> _prompts = new List<string>
{       "How do you most often feel the spirit?",
        "What do you do when you make a mistake?",
        "How does Jesus Christ help you overcome trials?",
        "What does God do to demonstrate His love for you?"
};

    private int _count = 0;

    private void ListingActivity()
    {
        DisplayWelcomeMessage("Listing");

        Console.Write("\nList as many responses as you can to the following prompt:");
        string prompt = GetRandomPrompt();
        Console.WriteLine($"\n--- {prompt} --- ");
        Console.Write("You may begin in: ");
        ShowNumberedCountdown(5);

        List<string> responses = GetListFromUser(prompt);
        _count = responses.Count;

        Console.WriteLine($"\nYou listed {_count} items. Great job!");
        DisplayEndingMessage("Listing", _durationInSeconds);

    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];

    }

    private List<string> GetListFromUser(string prompt)
    {
        List<string> responses = new List<string>();
        Stopwatch timer = new Stopwatch();
        timer.Start();


        Console.WriteLine(prompt);
        while (timer.ElapsedMilliseconds < _durationInMiliseconds(_durationInSeconds))
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            responses.Add(response);
            _count = _count + 1;
        }
        timer.Stop();

        return responses;


    }

    public void RunListingActivity()
    {
        ListingActivity();
    }
}