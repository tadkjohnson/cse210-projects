using System;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");

        // main messages
        
    
        DisplayWelcome();

        string userName = PromptUserName();
        float userNumber = favoriteNumber();

        float squaredNumber = getSquared(userNumber);

        DisplayResult(userName, userNumber, squaredNumber);
    }

    // welcome message function
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the machine err Program!");
    }

    // user name
    static string PromptUserName()
    {
        Console.Write("Please enter your user name: ");
        string name = Console.ReadLine();
        return name;
    }


    // user number 
    static float favoriteNumber()
    {
            Console.WriteLine("What is your favorite number? ");
            float favoriteNumber = float.Parse(Console.ReadLine());  
        return favoriteNumber;
    }

    // number squared away
    static float getSquared(float favoriteNumber)
    {
        return favoriteNumber * favoriteNumber;

    }
    static void DisplayResult(string name, float favoriteNumber, float squaredNumber)
    {
            Console.WriteLine($"You are {name}, your favorite number is {favoriteNumber}, and that number squared is {getSquared}");
    }



}






// Console.WriteLine("Welcome to the program!");
// Console.Writeline("Please enter your name: ");
// string name = Console.ReadLine();

// Console.Writeline("Please Enter your Favorite number: ");
// int numberFavorite = Console.ReadLine();


// Console.Writeline("");
// Console.Writeline($"{name} the square of your number is {squaredNumber}");
// Console.Writeline("");








//     }









// }