using System;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        List<double> numbers = new List<double>();

        double numberEntry = -1;

        Console.WriteLine("Enter a list of numbers, 0 to quit. please;  ");

        while (numberEntry != 0)
        {
            Console.Write("Enter a number (0 to quit)");
            numberEntry = double.Parse(Console.ReadLine());

            if (numberEntry != 0)
            {
                numbers.Add(numberEntry);
            }
        }

        // do the math   get total sum, average then length
        double sum = 0;
        


        foreach (double number in numbers)
        {
            sum += number;
        }

        // get largest 
        double largest = double.MinValue;

        foreach (double number in numbers)
        {
            if (number > largest)
            {
                largest = number;
            }
        }


        // get average
        double average = 0;
        average = sum / numbers.Count;


        // get length 
        int length = 0;
        length = numbers.Count;
    
  
        Console.WriteLine($"you have {numbers.Count} numbers in your list");
        Console.WriteLine($"The total of your number list is {sum}");
        Console.WriteLine($"The average of your list of numbers is {average}");
        Console.WriteLine($"The number of numbers in your list is {length}");
        
    }
}

 




// numbers.Add("16");
        // get size by  Console.WriteLine (words.Count);
        /* iterate thorugh a list  foreach loop   like this
        foreach (string word in words)
        {
            Console.WriteLine(word);
            }
            by index   

            for (int i = 0; i < words.Count; i++)
            {
                Console.WriteLine(words[i]);
                }


                instructions
                make a list by getting #'s from user
                get sum  or total
                average 
                and largest #

        */
 
 
       

            // for each(int number in numbers)
            // {
            //     Console.WriteLine(numbers);
            // }
        



