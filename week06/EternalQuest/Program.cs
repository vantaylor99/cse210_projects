using System;
using System.Diagnostics;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string _userInput = "";
        List<Goal> goals = new List<Goal>();
        int score = 0;
        LoadGoals(goals, ref score);

        while (_userInput != "5")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create a new goal.");
            Console.WriteLine("2. Record progress on goal.");
            Console.WriteLine("3. Display goals and progress.");
            Console.WriteLine("4. Show current score.");
            Console.WriteLine("5. Quit.");
            Console.WriteLine("Please make a selection.");
            _userInput = Console.ReadLine();


            if (_userInput == "1")
            {
                Console.Clear();
                Console.WriteLine("The input is 1");
                Console.WriteLine("What type of goal would you like to make?");
                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Eternal Goal");
                Console.WriteLine("3. Checklist Goal");
                string _secondUserInput = Console.ReadLine();
                if (_secondUserInput == "1")
                {
                    Console.WriteLine("What would you like to name your goal?");
                    string _name = Console.ReadLine();
                    Console.WriteLine("How many points is it worth?");
                    string _pointsString = Console.ReadLine();
                    int _points = int.Parse(_pointsString);

                    SimpleGoal goal = new SimpleGoal(_name, _points);
                    goals.Add(goal);
                }
                if (_secondUserInput == "2")
                {
                    Console.WriteLine("What would you like to name your goal?");
                    string _name = Console.ReadLine();
                    Console.WriteLine("How many points should you get each time you do it?");
                    string _pointsString = Console.ReadLine();
                    int _points = int.Parse(_pointsString);

                    EternalGoal goal = new EternalGoal(_name, _points);
                    goals.Add(goal);
                }
                if (_secondUserInput == "3")
                {
                    Console.WriteLine("What would you like to name your goal?");
                    string _name = Console.ReadLine();

                    Console.WriteLine("How many points should you get each time you make progress?");
                    string _pointsString = Console.ReadLine();
                    int _points = int.Parse(_pointsString);

                    Console.WriteLine("How many times should you do this goal before it's done? or a habbit?");
                    string _targetCountString = Console.ReadLine();
                    int _targetCount = int.Parse(_targetCountString);

                    Console.WriteLine("How many bonus points should you receive for completing this goal?");
                    string _bonusPointsString = Console.ReadLine();
                    int _bonusPoints = int.Parse(_bonusPointsString);

                    ChecklistGoal goal = new ChecklistGoal(_name, _points, _targetCount, _bonusPoints);
                    goals.Add(goal);
                }

            }
            if (_userInput == "2")
            {
                Console.Clear();
                Console.WriteLine("Goals and Progress");

                if (goals.Count == 0)
                {
                    Console.WriteLine("Error, no goals to display.");
                }
                else
                {
                    int index = 1;
                    foreach (Goal goal in goals)
                    {

                        Console.WriteLine($"{index}. {goal.GetStatus()}");
                        ++index;
                    }
                }

                Console.WriteLine("What goal did you complete?");
                string input = Console.ReadLine();
                int selectedIndex = int.Parse(input) - 1;

                if (selectedIndex >= 0 && selectedIndex < goals.Count)
                {
                    Goal selectedGoal = goals[selectedIndex];
                    selectedGoal.RecordEvent();
                    score += selectedGoal.GetPoints();
                    Console.WriteLine("Goal recorded! Points added!");
                }
                else
                {
                    Console.WriteLine("Invalid selection");
                }
                Console.WriteLine("Great job doing your goal!");
                Console.WriteLine("Press enter to continue...");
                Console.ReadLine();

            }
            if (_userInput == "3")
            {

                Console.Clear();
                Console.WriteLine("Goals and Progress");

                if (goals.Count == 0)
                {
                    Console.WriteLine("Error, no goals in list.");
                    Console.WriteLine("Press enter to continue.");
                    Console.ReadLine();
                }
                else
                {
                    int index = 1;
                    foreach (Goal goal in goals)
                    {

                        Console.WriteLine($"{index}. {goal.GetStatus()}");
                        ++index;
                    }
                    Console.WriteLine("\nPress Enter to continue...");
                    Console.ReadLine();
                }
            }
            if (_userInput == "4")
            {
                Console.Clear();
                Console.WriteLine($"Your current score is {score}");
                Console.WriteLine("\nPress Enter to continue...");
                Console.ReadLine();
            }
            if (_userInput == "5")
            {
                SaveGoals(goals, score);
                Console.WriteLine("Progress saved! Goodbye!");
            }
        }
    }
    static void SaveGoals(List<Goal> goals, int score)
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            foreach (Goal goal in goals)
            {
                writer.WriteLine(goal.ToFileFormat());
            }

            writer.WriteLine($"SCORE|{score}");
        }
    }
    static void LoadGoals(List<Goal> goals, ref int score)
    {
        if (File.Exists("goals.txt"))
        {
            string[] lines = File.ReadAllLines("goals.txt");
            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                if (parts[0] == "SimpleGoal")
                {
                    string name = parts[1];
                    int points = int.Parse(parts[2]);
                    bool isComplete = bool.Parse(parts[3]);
                    SimpleGoal goal = new SimpleGoal(name, points);
                    if (isComplete) goal.RecordEvent();
                    goals.Add(goal);
                }
                else if (parts[0] == "EternalGoal")
                {
                    string name = parts[1];
                    int points = int.Parse(parts[2]);
                    goals.Add(new EternalGoal(name, points));
                }
                else if (parts[0] == "ChecklistGoal")
                {
                    string name = parts[1];
                    int points = int.Parse(parts[2]);
                    bool isComplete = bool.Parse(parts[3]);
                    int targetCount = int.Parse(parts[4]);
                    int currentCount = int.Parse(parts[5]);
                    int bonusPoints = int.Parse(parts[6]);

                    ChecklistGoal goal = new ChecklistGoal(name, points, targetCount, bonusPoints);
                    goal.SetProgress(currentCount, isComplete);
                    goals.Add(goal);
                }
                else if (parts[0] == "SCORE")
                {
                    score = int.Parse(parts[1]);
                }
            }
        }
    }
}