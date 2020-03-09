using System;

namespace NumberLibrary
{
    public static class ExampleRun
    {
        public static void Run()
        {
            int[] list = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            int value = 7;
            Console.WriteLine("The number to find is 7");
            FindNumber(list, value);
            

        }
        public static void FindNumber(int[] list, int value)
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
    }
}
