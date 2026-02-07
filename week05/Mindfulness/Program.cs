using System;
using System.Collections.Generic;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");
         while (true)
        {
            Console.WriteLine("");
            Console.WriteLine("Mindfulness Program - Pick which activity you would like to do");
            Console.WriteLine("1 Breathing Activity");
            Console.WriteLine("2 Reflection Activity");
            Console.WriteLine("3 Listing Activity");
            Console.WriteLine("4 Quit");
            Console.Write("Pick a Nubmer 1-4: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                new BreathingActivity().Run();
            }
            else if (choice == "2")
            {
                new ReflectionActivity().Run();
            }
            else if (choice == "3")
            {
                new ListingActivity().Run();
            }
            else if (choice == "4")
            {
                break;
            }
            else
            {
                Console.WriteLine("Pick a Nubmer.");
            }

            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
        }
    }
}

