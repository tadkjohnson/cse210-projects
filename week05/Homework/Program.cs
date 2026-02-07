using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");

        Assignment a1 = new Assignment("John Doe", "Multiplication");
        Console.WriteLine(a1.GetSummary());

        MathAssignment a2 = new MathAssignment("Jane Dough". "Fractions", "7.3", "8-19");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        MathAssignment a3 = new MathAssignment("Lux Luthor". "Division", "Get Superman");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetHomeworkList());



    }
}