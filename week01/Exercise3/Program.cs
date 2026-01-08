using System;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int x = RandomNumberGenerator.Next(1, 101);   // to get 100 numbers instead of 99


        Console.WriteLine("Hello World! This is the Exercise 3 Project.");
        Console.WriteLine("We are going to play a guess the number game");
        Console.WriteLine("I will let you know if you are to high, low, or correct.");


        {
            Console.Write("What is your guess? ");
            string valueFromUser = Console.ReadLine();
            int guess = int.Parse(valueFromUser);

            if (guess > x)
            {
                Console.Write("Your guess it is to high");
            }
            else if (guess < x)
            {
                Console.Write("Your guess it is to low");
            }



            Console.WriteLine($"Random number; {x}");







            Console.WriteLine("Want to play a game Y/N? ");
            string valueFromUser2 = Console.ReadLine();

            //        if valueFromUser2 = Y
            //        if valueFromUser2 = N
            //            else;
            {
                //          Console.WriteLane("Thanks for playing");
            }



        }
















    }