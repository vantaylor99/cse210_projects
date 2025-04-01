using System.Diagnostics;

public class Breathe : Activities
{


    private void BreathingAcivity()
    {
        DisplayWelcomeMessage(_ActivityName);


        Stopwatch timer = new Stopwatch();
        timer.Start();

        while (timer.ElapsedMilliseconds < _durationInMiliseconds(_durationInSeconds))
        {

            Console.Write($"\n\nBreathe in... ");
            ShowNumberedCountdown(5);

            Console.Write($"\nNow breathe out... ");
            ShowNumberedCountdown(6);
        }

        timer.Stop();

        DisplayEndingMessage(_ActivityName, _durationInSeconds);

    }

    public void RunBreathingActivity()
    {
        BreathingAcivity();
    }


}