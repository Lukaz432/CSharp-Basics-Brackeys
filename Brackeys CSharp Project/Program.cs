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

            Console.WriteLine("A confident young man named..");

            Console.ReadLine();

            Console.WriteLine("..Stumbled upon Brackey's youtube channel and decided to become a..");

            Console.ReadLine();

            Console.WriteLine("He then decided to take a sip of..");

            Console.ReadLine();

            Console.WriteLine("..and with all that energy wanted to create a..");

            Console.ReadLine();

            Console.WriteLine("..but realized he does not have the knowledge to do so, so he..");

            Console.ReadLine();

            Console.WriteLine("..yet that was not enough. Instead, he..");

            Console.ReadLine();

            Console.WriteLine("..Although, after all these hours spent, he was full of passion and joy, the man named..");

            Console.ReadLine();

            Console.WriteLine("..just melted into his chair after losing so much sleep..\n \n THE END");

            //Makes terminal wait for input before closing
            Console.ReadKey();
        }
    }
}
