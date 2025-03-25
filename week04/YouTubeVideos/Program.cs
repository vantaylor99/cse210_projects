using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video();
        video1.SetTitle("Homemade Chemical Weapons");
        video1.SetAuthor("Mark Rober");
        video1.SetLength(330);
        video1.AddComment("Jimmy Fallon: This video helped me so much.");
        video1.AddComment("MrBeast: How much to make one and then set it off in the ocean? ");
        video1.AddComment("Bill Nye: I can top that.");

        Console.WriteLine($"Title: {video1.GetTitle()}");
        Console.WriteLine($"Author: {video1.GetAuthor()}");
        Console.WriteLine($"Length: {video1.GetLength()} seconds.");
        Console.WriteLine($"Number of Comments: {video1.GetComments().Count}");
        Console.WriteLine();


        foreach (Comment comment in video1.GetComments())
        {
            Console.WriteLine($"- {comment.GetName()}: {comment.GetCommentText()}");
        }
        Console.WriteLine();

        Video video2 = new Video();
        video2.SetTitle("Connecting with Jesus Christ");
        video2.SetAuthor("David A. Bednar");
        video2.SetLength(379.8);
        video2.AddComment("Russel M. Nelson: This video was fire! Keep up the good work Dave!");
        video2.AddComment("The Pope: Gas content coming from good ole David, you're spitting facts though. ");
        video2.AddComment("Sister Bednar: If only you could cook food as well as you cook in this video. ");

        Console.WriteLine($"Title: {video2.GetTitle()}");
        Console.WriteLine($"Author: {video2.GetAuthor()}");
        Console.WriteLine($"Length: {video2.GetLength()} seconds.");
        Console.WriteLine($"Number of Comments: {video2.GetComments().Count}");
        Console.WriteLine();

        foreach (Comment comment in video2.GetComments())
        {
            Console.WriteLine($"- {comment.GetName()}: {comment.GetCommentText()}");
        }
        Console.WriteLine();

        Video video3 = new Video();
        video3.SetTitle("How to Dunk");
        video3.SetAuthor("Kim Jong Un");
        video3.SetLength(459.2);
        video3.AddComment("Lebron James: This video is cap Kim, you can't dunk. ");
        video3.AddComment("Tom Brady: I'll actually quit playing football the day you actually can dunk.");
        video3.AddComment("Jeffery R. Holland: Bretheren Bretheren, lets be civil now, let the man dunk. Don't be Cynical.");

        Console.WriteLine($"Title: {video3.GetTitle()}");
        Console.WriteLine($"Author: {video3.GetAuthor()}");
        Console.WriteLine($"Length: {video3.GetLength()} seconds.");
        Console.WriteLine($"Number of Comments: {video3.GetComments().Count}");
        Console.WriteLine();

        foreach (Comment comment in video3.GetComments())
        {
            Console.WriteLine($"- {comment.GetName()}: {comment.GetCommentText()}");
        }
        Console.WriteLine();





    }
}