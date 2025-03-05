using System;

class Program
{
    static void Main(string[] args)
    {

       
        string keepPlaying = "yes";

        while (keepPlaying == "yes")
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            int guess = 0;
            string higherLower = "";

            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                string guessFromUser = Console.ReadLine();
                guess = int.Parse(guessFromUser);

                if (guess > magicNumber)
                {
                    higherLower = "Lower";
                }
                else if (guess < magicNumber)
                {
                    higherLower = "Higher";
                }
                else
                {
                    Console.WriteLine("Correct! ");
                }
                Console.WriteLine(higherLower);
            }
            
        
        Console.Write("Would you like to play again? ");
        string keepPlayingInput = Console.ReadLine();
        keepPlaying = keepPlayingInput;
        }
        
        Console.WriteLine("Thanks for playing!");
    }
}