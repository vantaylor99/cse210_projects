using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
        int userNumber = -1;
        List<int> numbers = new List<int>();



        // Loop for user input
        while (userNumber != 0)
        {
            Console.Write("Enter number: ");
            string input = Console.ReadLine();
            userNumber = int.Parse(input);

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        // Initial variables
        float sum = 0;
        int highest = int.MinValue;
        int lowest = int.MaxValue;

        for (int i = 0; i < numbers.Count; i++)
        {
            // sum variable / appending new numbers
            sum += numbers[i];

            // Find highest and lowest
            if (highest < numbers[i])
            {
                highest = numbers[i];
            }
            if (lowest > numbers[i] && numbers[i] > 0)
            {
                lowest = numbers[i];
            }
        }

        // Average
        float average = (sum / numbers.Count);

        // Sort & print number list
        numbers.Sort();
        for (int i = 0; i < numbers.Count; i++)
        {
            Console.WriteLine("The sorted list is: ");
            Console.WriteLine(numbers[i]);
        }

        // Results
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The highest number is: {highest}");
        Console.WriteLine($"The lowest number is: {lowest}");













    }
}