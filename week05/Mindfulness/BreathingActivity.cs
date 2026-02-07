using System;
using System.Collections.Generic;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity() 
        : base("Breathing Activity",
        "This activity will help you control your breathing and help your Blood Pressure.")
    {
    }

    public void Run()
    {
        StartActivity();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in... \t");
            ShowCountdown(12);
            Console.Write("Breathe out... \n");
            ShowCountdown(6);
        }
        EndActivity();
    }
}