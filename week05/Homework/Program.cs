using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment();
        assignment1.SetStudentName("George Russel");
        assignment1.SetTopic("Race Cars");

        MathAssignment assignment2 = new MathAssignment();
        assignment2.SetStudentName("George Russel");
        assignment2.SetTopic("Race Cars");
        assignment2.SetTextbook("7.3");
        assignment2.SetProblems("8-19");

        WritingAssignment assignment3 = new WritingAssignment();
        assignment3.SetStudentName("George Russel");
        assignment3.SetTopic("Race Cars");
        assignment3.SetTitle("Apples to Eat");
        

        Console.WriteLine(assignment1.GetSummary());
        Console.WriteLine(assignment2.GetHomeworkList());
        Console.WriteLine(assignment3.GetWritingInformation());
    }
}