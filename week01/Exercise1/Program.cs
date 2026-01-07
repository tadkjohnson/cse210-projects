using System;
using System.Runtime.ExceptionServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Hello, What is your first name? ");
        string first = Console.ReadLine();

        Console.Write("What is your last name? ");
        string last = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine($"Are you really {last}, {first} {last}? ");
        Console.WriteLine();
        
    }
}