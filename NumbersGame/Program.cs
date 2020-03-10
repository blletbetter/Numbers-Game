using System;
using NumberLibrary;


namespace NumbersGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;
            do
            {
                //if(input != null)
                //{
                //    Console.WriteLine("Press any key to continue...");
                //    Console.ReadKey();
                //}
                MainMenu();
                var val = Console.ReadLine();
                while (ValidOption(val, out input)==false)
                {
                    MainMenu();
                    val = Console.ReadLine();
                }
                
                switch (input)
                {
                    case 1:
                        Console.Clear();
                        Run();

                        Console.WriteLine("Press any key to continue...");
                        Console.Read();
                        break;
                    case 2:
                        Console.Clear();
                        HumanGuess();
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        ComputerGuess();
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine("\n\n\nThanks for playing!");
                        return;
                    default:
                        Console.WriteLine("\n\nInvalid option, please try again.");
                        Console.Clear();
                        
                        break;

                }
                
            } while (input != 4);
            
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
                    var val = Console.ReadLine();
                    while (ValidOption(val, out input) == false)
                    {
                        Console.WriteLine("\n \nYour guess: ");
                        input = Int32.Parse(Console.ReadLine());
                    }
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
                int rndNum, input, value, attempts;
                value = list.Length / 2;
                attempts = 0;
                Console.WriteLine("For this, you will input a number for the computer to guess between 1 - 100.");
                Console.WriteLine("You will then tell the computer if it's guess is higher or lower then the number you entered.");
                do
                {
                    Console.WriteLine("Enter a number between 1 - 100");
                    Console.WriteLine("Your number to be guessed is: ");
                    var val = Console.ReadLine();
                    while (ValidOption(val, out rndNum) == false)
                    {
                        Console.WriteLine("Enter a number between 1 - 100");
                        Console.WriteLine("Your number to be guessed is: ");
                        val = Console.ReadLine();
                    }
                } while (rndNum < 1 && rndNum > 100);
                while (rndNum != list[value])
                {
                    attempts++;
                    int[] list2 = list[(value)..];
                    int[] list3 = list[..(value)];
                    Console.WriteLine("\n \n \n Press any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine($"\nThe number the computer is trying to guess is {rndNum}");
                    Console.WriteLine($"Computer attempt {attempts}");
                    Console.WriteLine($"\nThe computer's guess is {list[value]} \n \n");
                    Console.WriteLine("Enter \n1.) if the guess is higher than your number. \n2.) if the guess is lower than your number.");
                    Console.WriteLine("3.) if the guess was correct");
                    do
                    {
                        Console.WriteLine("Enter a number between 1 - 3");
                        Console.WriteLine("Your responce is: ");
                        var val = Console.ReadLine();
                        while (ValidOption(val, out input) == false)
                        {
                            Console.WriteLine("Enter a number between 1 - 3");
                            Console.WriteLine("Your responce is: ");
                            val = Console.ReadLine();
                        }
                    } while (input < 1 && input > 3);
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
                Console.WriteLine($"Computer attempt {attempts}");
                Console.WriteLine($"\nThe computer's guess is {list[value]} \n \n");
            }
            static void Run()
            {
                int[] list = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                int value;
                Console.WriteLine("Enter a number 1 - 10");
                var val = Console.ReadLine();
                while (ValidOption(val, out value) == false)
                {
                    Console.WriteLine("Enter a number 1 - 10");
                    val = Console.ReadLine();
                }
                while (value > 10 || value < 1)
                {
                    Console.WriteLine("Enter a number 1 - 10");
                    while (ValidOption(val, out value) == false)
                    {
                        Console.WriteLine("Enter a number 1 - 10");
                        val = Console.ReadLine();
                    }
                }
                Console.WriteLine($"The number to find is {list[value]}");
                FindNumber(list, value);
                


            }
            static void FindNumber(int[] list, int value)
            {
                int middle = list.Length / 2;
                Console.WriteLine($"\nThe computer guesses the number is {list[middle]}");
                while (list[middle] != value)
                {



                    int[] list2 = list[(middle)..];
                    int[] list3 = list[..(middle)];
                    if (list[middle] > value)
                    {
                        list = list3;
                        Console.WriteLine("The array becomes: ");
                        foreach (var i in list)
                        {
                            Console.Write($"{i}, ");
                        }
                        middle = list.Length / 2;


                    }
                    if (list[middle] < value)
                    {
                        list = list2;
                        Console.WriteLine("The array becomes: ");
                        foreach (var i in list)
                        {
                            Console.Write($"{i}, ");
                        }
                        middle = list.Length / 2;

                    }
                    Console.WriteLine($"\nThe computer guesses the number is {list[middle]}");
                }
                Console.WriteLine($"The computer guessed the correct number!");
            }
            static bool ValidOption(string input, out int option)
            {
                return Int32.TryParse(input, out option);
            }
            static void MainMenu()
            {
                Console.Clear();
                Console.WriteLine("Welcome to the number guessing game.");
                Console.WriteLine("Can you beat the computer in attempts to guess a random number?");
                Console.WriteLine("Choose one of the following:");
                Console.WriteLine("1.) See the computers thought process \n2.) Guess a number yourself \n3.) Have the computer guess your number \n4.) Exit");

                Console.Write("You choose: ");
            }
        }
    }
}
