using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);
        //int number = 4;
        int guess = -5;
        while (number != guess)  
        {
            Console.Write("What is the magic number? ");
            guess = int.Parse(Console.ReadLine());

            if (number > guess)
            {
                Console.WriteLine ("Hmm. That number is too low. Please guess something that is HIGHER.");
            }
            else if (number < guess)
            {
                Console.WriteLine ("Too bad. The number you guessed to too high. Please guess another number that is LOWER.");
            }
            else
            {
                Console.WriteLine ($"Bingo! You correctly guessed that {number} is the magic number!");    
            }

        }

    }
}