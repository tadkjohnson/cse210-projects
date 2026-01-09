using System;
using System.Collections.Concurrent;


class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        bool playAgain = true;


        Console.WriteLine("Hello World! This is the Exercise 3 Project.");
        Console.WriteLine("We are going to play a guess the number game");
        Console.WriteLine("I will let you know if you are to high, low, or correct.");

        while (playAgain)
        {

            int x = randomGenerator.Next(1, 101);   // to get 100 numbers instead of 99Console.Write("What is your guess? ");
            bool isCorrect = false;

            while (!isCorrect)
            {
                Console.Write("what is your guess? ");
                int guess = int.Parse(Console.ReadLine());

                if (guess > x)
                {
                    Console.WriteLine("Your guess it is to high");
                }
                else if (guess < x)
                {
                    Console.WriteLine("Your guess it is to low");
                }
                else
                {
                    Console.WriteLine("Correct!");
                    isCorrect = true;
                }
            }
            Console.Write("Do you want to play again? (Y/N) ");
            string answer = Console.ReadLine();
            if (answer == N)
                playAgain = false;
        }
    }
}