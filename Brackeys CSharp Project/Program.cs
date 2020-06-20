using System;

namespace Brackeys_CSharp_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            // Appearance

            Console.Title = "Mega Terminal";
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WindowHeight = 30;

            // Conversation

            Console.WriteLine("A confident young man named..");

            Console.ReadLine();

            Console.WriteLine("..Stumbled upon Brackey's youtube channel and decided to become a..");

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.ReadLine();

            Console.WriteLine("He then decided to take a sip of..");

            Console.ReadLine();

            Console.WriteLine("..and with all that energy wanted to create a..");

            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.ReadLine();

            Console.WriteLine("..but realized he does not have the knowledge to do so, so he..");

            Console.ReadLine();

            Console.WriteLine("..yet that was not enough. Which is why he..");

            Console.ForegroundColor = ConsoleColor.Green;

            Console.ReadLine();

            Console.WriteLine("..Although, after all these hours spent, he was full of passion and joy, the man named..");

            Console.ReadLine();

            Console.WriteLine("..just melted into his chair after losing so much sleep..");

            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("THE END.");

            //Makes terminal wait for input before closing
            Console.ReadKey();
        }
    }
}
