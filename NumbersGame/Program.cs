using System;
using NumberLibrary;

namespace NumbersGame
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            HumanGuess();

            static void HumanGuess()
            {
                int input;
                int[] list = new int[1000];
                for (int i = 0; i < list.Length;)
                {
                    list[i] = ++i;
                }
                Random random = new Random();
                int rndNum = random.Next(list.Length);
                Console.WriteLine("Please guess a number between 1 - 1000. \nYou have 11 guesses. ");
                int f;
                for (f = 11; f > 0; --f)
                {
                    Console.WriteLine("\n \nYour guess: ");
                    input = Int32.Parse(Console.ReadLine());
                    if (input == rndNum)
                    {
                        break;
                    }
                    else if(input > rndNum)
                    {
                        Console.WriteLine("Your guess is higher than the number.");
                        Console.WriteLine($"you have {f - 1} guesses left.");
                    }
                    else if(input < rndNum)
                    {
                        Console.WriteLine("Your guess is lower than the number.");
                        Console.WriteLine($"you have {f - 1} guesses left.");
                    }

                }
                if(f > 0)
                {
                    Console.WriteLine("You guessed correctly!");
                }
                else
                {
                    Console.WriteLine("You ran out of guesses. \n \nGame Over!");
                }
                
            }
        }
    }
}
