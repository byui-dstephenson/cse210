using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //Create a list to hold the numbers
        List<int> numbers = new List<int>();

        //Have the user populate the list
        Console.WriteLine($"\r\nPlease enter a number (one at a time) to added it to your number list. \r\nWhen finished, please enter a 0 to continue.");
        int numberEntry = -1;
        while (numberEntry !=0)
        {
            Console.Write("Number: "); string EnteredNumber = Console.ReadLine();
            numberEntry = int.Parse(EnteredNumber);

            if (numberEntry != 0)
            {
                numbers.Add(numberEntry);
            }
        }

        //Sum the numbers from the list
        int sum = 0;
        foreach (int number in numbers)    
        {
            sum += number;
        }
        Console.WriteLine ($"\r\nThe sum of the numbers is: {sum}");

        //Get the average of the numbers in the list
        float avg = ((float)sum) /numbers.Count;
        Console.WriteLine($"The average of the numbers is: {avg}");

        //Get the highest number in the list
        Console.WriteLine($"The highest number in the list is: " + numbers.Max());

        //Get the lowest number in the list
        Console.WriteLine($"The lowest number in the list is: " + numbers.Min());
    }
}