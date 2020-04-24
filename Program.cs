using System;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            string levelchoice ="";
            string level = "";
            Console.WriteLine("Welcome to the Number Guessing Game!");

            Console.WriteLine("Now, choose a level (easy, medium or hard): ");
            levelchoice = Console.ReadLine();
            level = levelchoice.ToLower();

            if (level == "easy")
            {
                while (true)
                {
                    var rand = new Random();
                    int randno = rand.Next(1, 11);
                    int count = 1;
                    while (true)
                    {
                        Console.WriteLine("I am a number between 1 and 10. What am I? (Enter 0 to quit or start afresh) ");
                        int input = Convert.ToInt32(Console.ReadLine());
                        if (input == 0)
                            return;
                        else if (input != randno)
                        {
                                Console.WriteLine("That was wrong, try again.");
                                Console.WriteLine("You have {0} attempt(s) left.", 6 - count);
                                ++count;
                                
                                if (7 - count == 0)
                                {
                                    Console.WriteLine("Game over! I was {0}.", count);
                                    break;

                                }
                                // continue;
                                                                                                                    
                        }
                        else
                        {
                            Console.WriteLine("You got it right! The number was {0}!", 
                                           randno);
                            Console.WriteLine("It took you {0} {1}.\n", count, 
                                           count == 1 ? "try" : "tries");
                            break;
                        }
                    }

                }
                
            }
            else if (level == "medium")
            {
                 while (true)
                {
                    var rand = new Random();
                    int randno = rand.Next(1, 21);
                    int count = 1;
                    while (true)
                    {
                        Console.WriteLine("I am a number between 1 and 20. What am I? (Enter 0 to quit or start afresh) ");
                        int input = Convert.ToInt32(Console.ReadLine());
                        if (input == 0)
                            return;
                        else if (input != randno)
                        {
                                Console.WriteLine("That was wrong, try again.");
                                Console.WriteLine("You have {0} attempt(s) left.", 4 - count);
                                ++count;
                                
                                if (5 - count == 0)
                                {
                                    Console.WriteLine("Game over! I was {0}.", count);
                                    break;
                                    
                                }
                                // continue;
                                                                                                                    
                        }
                        else
                        {
                            Console.WriteLine("You got it right! The number was {0}!", 
                                           randno);
                            Console.WriteLine("It took you {0} {1}.\n", count, 
                                           count == 1 ? "try" : "tries");
                            break;
                        }
                    }

                }
            }
            else 
            {
                 while (true)
                {
                    var rand = new Random();
                    int randno = rand.Next(1, 51);
                    int count = 1;
                    while (true)
                    {
                        Console.WriteLine("I am a number between 1 and 50. What am I? (Enter 0 to quit or start afresh) ");
                        int input = Convert.ToInt32(Console.ReadLine());
                        if (input == 0)
                            return;
                        else if (input != randno)
                        {
                                Console.WriteLine("That was wrong, try again.");
                                Console.WriteLine("You have {0} attempt(s) left.", 3 - count);
                                ++count;
                                
                                if (4 - count == 0)
                                {
                                    Console.WriteLine("Game over! I was {0}.", count);
                                    break;
                                    
                                }
                                // continue;
                                                                                                                    
                        }
                        else
                        {
                            Console.WriteLine("You got it right! The number was {0}!", 
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
}
