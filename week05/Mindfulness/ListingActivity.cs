using System;
using System.Collections.Generic;
using System.Threading;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "Who are some of your personal heroes?"
    };
    private Random _random = new Random();
    public ListingActivity()
        : base("Listing Activity",
        "This activity will help you reflect on the good things in your life, try to list as many things as you can.")
    {
    }
    public void Run()
    {
        StartActivity();

        string prompt = _prompts[_random.Next(_prompts.Count)];
        Console.WriteLine($"{prompt}");
        Console.WriteLine("You may begin in:");
        ShowCountdown(5);

        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("Write here :");
            items.Add(Console.ReadLine());
        }
        Console.WriteLine($"You listed {items.Count} items!");
        EndActivity();
    }
}