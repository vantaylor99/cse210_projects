using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Activity run = new Running("03 Nov 2022,", 60, 125);
        Activity bike = new Biking("03 Nov 2022,", 45, 80);
        Activity swim = new Swimming("03 Nov 2022,",15 , 15);

        List<Activity> activities = new List<Activity>();
        activities.Add(run);
        activities.Add(bike);
        activities.Add(swim);


        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}