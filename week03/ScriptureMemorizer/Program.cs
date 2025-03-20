using System;
using System.Security.Cryptography.X509Certificates;

class Program
{


    // The creative addition I did was figuring out a way for the program to only hide letters in the words rather than letters and punctuation. 
    // I also added a random number of words to hide each time the user presses enter.
    static void Main()
    {
        string UserInput = "";



        Scripture scripture = new Scripture();
        Random random = new Random();
        int randomIndex;
        int randomCount;
        int WordsLeftToHide;

        Console.Clear();
        WordsLeftToHide = scripture.DisplayWords();
        while (UserInput != "quit")
        {
            Console.WriteLine("Press enter to continue or type 'quit' to finish. ");
            UserInput = Console.ReadLine();

            randomCount = random.Next(2, 4);
            if (randomCount > WordsLeftToHide)
            {
                randomCount = WordsLeftToHide;
            }


            for (int i = 0; i < randomCount; i++)
            {
                bool IsAlreadyHidden;
                randomIndex = random.Next(0, scripture._scriptureList.Count);
                IsAlreadyHidden = scripture._scriptureList[randomIndex].IsHidden;
                if (IsAlreadyHidden != true)
                {
                    scripture._scriptureList[randomIndex].Hide();
                }

                else
                {
                    i--;
                }
                Console.Clear();
            }
            WordsLeftToHide = scripture.DisplayWords();
            if (WordsLeftToHide == 0)
            {
                UserInput = "quit";
            }




        }


    }
}