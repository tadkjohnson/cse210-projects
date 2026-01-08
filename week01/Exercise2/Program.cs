using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");


        Console.Write("Hello, to figure out your grade for a course please enter your percent? ");
        string valueFromUser = Console.ReadLine();
        string letter = "";

        int x = int.Parse(valueFromUser);

        if (x > 93)
        {
            letter = "A";

        }
        else if (x > 90) 
        {
            letter = "A-";

        }

        else if (x > 87) 

        {
            letter = "B+";

        }

        else if (x > 83)

        {
            letter = "B";

        }

        else if (x > 80) 

        {
            letter = "B-";

        }

        else if (x > 77) 

        {
            letter = "C+";

        }

        else if (x > 73) 

        {
            letter = "C";

        }

        else if (x > 70) 

        {
            letter = "C-";

        }

        else if (x > 67) 

        {
            letter = "D+";

        }

        else if (x > 63) 

        {
            letter = "D";

        }

        else if (x > 60) 

        {
            letter = "D-";

        }

        else if (x < 60) 

        {
            letter = "F";

        }
    
        // now that you know the grade print it 
        {
            Console.WriteLine($"Your letter grade is: {letter}");
            if (x > 70)
            {
                Console.Write("Good Job! You have passed the course.");
            }
            else if (x < 70)
            {
                Console.Write("Please retake the course, utilize the tutors and teachers, you can do this!.");
            }
 
        }


//     string letter = "A";











//         {
//             Console.WriteLine("Your grade is an A, Great Job!");
//         }

//         else 
        
//         if (x > 80);

//         {
//             Console.WriteLine("Your grade is an B, Good Job!");
//         }
//             else
//             if (x > 70) ;
//             {
//             Console.WriteLine("Your grade is an C, You have it in you do do better.");
//             }


//             else if (x > 60) ;

//         {
//             Console.WriteLine("Your grade is an D, Please spend more time studying and doing the work.");
//         }


//             else
        
//             {
//                 Console.WriteLine("Your grade is an F, Please reach out to a tutor session weekly and retake the course. ");
//             }


    }

}