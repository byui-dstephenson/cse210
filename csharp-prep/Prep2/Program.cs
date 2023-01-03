using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the CSE210 Grade Calculator!");
        Console.WriteLine("Please enter your grade percentage (without the percent sign).");

        string Grade = Console.ReadLine();
        float GradePercentage = float.Parse(Grade);
        string Letter = "";

        if (GradePercentage >= 90)
        {
           Letter = "A";
        }   
        else if (GradePercentage >= 80)
        {
            Letter = "B";
        }
        else if (GradePercentage >= 70)
        { 
            Letter = "C";
        }
        else if (GradePercentage >= 60)
        {
            Letter = "D";
        }
        else 
        {
            Letter = "F";
        }

        Console.WriteLine($"You received an {Letter} in the class.");
        if (GradePercentage >= 70)
        {
            
            Console.WriteLine("This means you have passed!");
        }
        else
        {
            Console.WriteLine("This means you have failed the class.");
            Console.WriteLine("Please consult with the teach to see how you can improve for the next time you take the class.");
        }
            



    }
}