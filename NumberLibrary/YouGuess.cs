using System;
using System.Collections.Generic;
using System.Text;

namespace NumberLibrary
{
    public class YouGuess
    {
        public static void Run()
        {
            int[] list = new int[1000];
            for(int i = 0; i < list.Length;)
            {
                list[i] = ++i;
            }
            Random random = new Random();
            int rndNum = random.Next(list.Length);
            int input;
            Console.WriteLine("Please guess a number between 1 - 1000. \n \nYour guess: ");
            input = Int64..
            while(input != rndNum)
            {

            }
        }
    }
}
