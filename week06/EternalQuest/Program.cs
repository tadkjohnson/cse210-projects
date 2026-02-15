using System;
using System.IO;
using System.Transactions;
// using System.IO.StreamWriter;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");

        GoalManager manager = new GoalManager();


        bool running = true;

        while (running)
        {
            Console.WriteLine("  ");
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Goal");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Load");
            Console.WriteLine("6. Show Score");
            Console.WriteLine("7. Quit");
            Console.WriteLine("Pick a number 1-7 ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("What is the goals name");
                string name = Console.ReadLine();

                Console.WriteLine("descripe the goal ");
                string description = Console.ReadLine();
                Console.Write("enter Points ");
                int points = int.Parse(Console.ReadLine());

                Goal goal = new SimpleGoal(name, description, points, false);
                manager.AddGoal(goal);
            }
            else if (choice == "2")
            {
                manager.DisplayGoals();

            }
            else if (choice == "3")
            {
                manager.DisplayGoals();
                Console.Write("Which goal to record? ");
                int index = int.Parse(Console.ReadLine()) - 1;

                manager.RecordGoal(index);
            }
            else if (choice == "4")
            {
                Console.WriteLine("What would like to call your save file? ");
                string fileName = Console.ReadLine();
                manager.Save(fileName);

                Console.WriteLine("file saved");
            }
            else if (choice == "5")
            {
                Console.WriteLine($"Enter the file name of your Goal list to load ");
                string loadFile = Console.ReadLine();
                manager.Load(loadFile);
            }
            else if (choice == "6")
            {
                manager.DisplayScore();
            }
            else if (choice == "7")
                running = false;

        }
    }
}







// 