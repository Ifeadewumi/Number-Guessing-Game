using System;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            string levelchoice ="";
            Console.WriteLine("Welcome to the Number Guessing Game!");

            while (true)
            {
                var rand = new Random();
                int randno = rand.Next(1, 11);
                int count = 1;
                while (true)
                {
                    Console.Write("Enter a number between 1 and 10(0 to quit):");
                    int input = Convert.ToInt32(Console.ReadLine());
                    if (input == 0)
                        return;
                    else if (input != randno)
                    {
                        Console.WriteLine("That was wrong, try again.");
                        ++count;
                        continue;
                    }                
                    else
                    {
                        Console.WriteLine("You guessed it! The number was {0}!", 
                                           randno);
                        Console.WriteLine("It took you {0} {1}.\n", count, 
                                           count == 1 ? "try" : "tries");
                        break;
                    }
                }
            }
        }
    }
}
