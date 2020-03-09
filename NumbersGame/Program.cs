using System;
using NumberLibrary;

namespace NumbersGame
{
    class Program
    {
        static void Main(string[] args)
        {


            //HumanGuess();
            ComputerGuess();

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
                    else if (input > rndNum)
                    {
                        Console.WriteLine("Your guess is higher than the number.");
                        Console.WriteLine($"you have {f - 1} guesses left.");
                    }
                    else if (input < rndNum)
                    {
                        Console.WriteLine("Your guess is lower than the number.");
                        Console.WriteLine($"you have {f - 1} guesses left.");
                    }

                }
                if (f > 0)
                {
                    Console.WriteLine("You guessed correctly!");
                }
                else
                {
                    Console.WriteLine("You ran out of guesses. \n \nGame Over!");
                }

            }
            static void ComputerGuess()
            {
                int[] list = new int[100];
                for (int i = 0; i < list.Length;)
                {
                    list[i] = ++i;
                }
                int rndNum, input, value;
                value = list.Length / 2;
                
                Console.WriteLine("For this, you will input a number for the computer to guess btween 1 - 100.");
                Console.WriteLine("You will then tell the computer if it's guess is higher or lower then the number you entered.");
                do
                {
                    Console.WriteLine("Your number to be guessed is: ");
                    rndNum = Int32.Parse(Console.ReadLine());
                    if (rndNum > 100 || rndNum < 1)
                    {
                        Console.WriteLine("number entered is outside needed field. \n \n Try again. \n");
                    }
                } while (rndNum < 1 && rndNum > 100);
                while(rndNum != list[value])
                {
                    int[] list2 = list[(value)..];
                    int[] list3 = list[..(value)];
                    Console.WriteLine("\n \n \n Press any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine($"\nThe number the computer is trying to guess is {rndNum}");
                    Console.WriteLine($"\nThe computer's guess is {list[value]} \n \n");
                    Console.WriteLine("Enter \n1.) if the guess is higher than your number. \n2.) if the guess is lower than your number.");
                    Console.WriteLine("Your responce is: ");
                    input = Int32.Parse(Console.ReadLine());
                    switch (input)
                    {
                        case 1:
                            list = list3;
                            Console.WriteLine("The array becomes: ");
                            foreach (var i in list)
                            {
                                Console.Write($"{i}, ");
                            }
                            value = list.Length / 2;
                            break;
                        case 2:
                            list = list2;
                            Console.Write("The array becomes: ");
                            foreach (var i in list)
                            {
                                Console.Write($"{i}, ");
                            }
                            value = list.Length / 2;
                            break;
                        default:
                            Console.WriteLine("Choice was not a valid option.");
                            break;
                    }
                }
                Console.WriteLine("\n \n \n Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine($"\nThe number the computer is trying to guess is {rndNum}");
                Console.WriteLine($"\nThe computer's guess is {list[value]} \n \n");
            }
        }
    }
}
