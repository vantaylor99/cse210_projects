using System;

class Program
{
    static void Main(string[] args)
    {
        // I added a little creativity in a couple different ways on my program, one was adding the bell sound at the end of countdowns.
        // Mainly for the breathing activity. (This sound is disable by VS Code by default so to hear it you have to toggle "Integrated: Enable Bell" to "on" in VS Code)
        // I also discovered that most of the animations looked better when the console cursor was hidden so I figured out a way to hide it, then re-enable it in animations. 
        // I also added a way so that the animations just write over themselves rather than use a space because they are smoother, then at the end it cleans up the animation
        // By overwriting them with spaces. Found in ShowNumberedCountdown funciton. 



        string _userInput = "";

        while (_userInput != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflection activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            _userInput = Console.ReadLine();

            if (_userInput == "1")
            {
                string _activityInput = "Breathing";

                Breathe activity1 = new Breathe();
                activity1.SetActivityName(_activityInput);
                activity1.RunBreathingActivity();

            }
            else if (_userInput == "2")
            {
                string _activityInput = "Reflecting";

                Reflection activity1 = new Reflection();
                activity1.SetActivityName(_activityInput);
                activity1.RunReflectionActivity();

            }

            else if (_userInput == "3")
            {
                string _activityInput = "Listing";

                Listing activity1 = new Listing();
                activity1.SetActivityName(_activityInput);
                activity1.RunListingActivity();

            }

            else if (_userInput == "4")
            {
                Console.WriteLine("Goodbye! Thanks for spending time in the relaxation app!");
            }

            else if (_userInput != "4")
            {
                Console.WriteLine("Invalid input. Press Enter to try again.");
                Console.ReadLine();
            }
        }
    }
}