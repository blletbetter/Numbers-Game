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
            foreach(var i in list)
            {
                Console.WriteLine(i);
            }
        }
    }
}
