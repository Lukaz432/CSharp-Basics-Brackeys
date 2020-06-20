using System;

namespace Brackeys_CSharp_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            // Appearance

            Console.Title = "Mega Terminal";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WindowHeight = 30;

            // Conversation

            Console.WriteLine("WHO ARE YOU?!");

            Console.ReadLine();

            Console.WriteLine("My name is T-1000. \nI am a droid from the future.");
            Console.WriteLine("What year are you from?");

            Console.ReadLine();

            Console.WriteLine("I am aware of that. I am from the year 2077.");

            //Makes terminal wait for input before closing
            Console.ReadKey();
        }
    }
}
