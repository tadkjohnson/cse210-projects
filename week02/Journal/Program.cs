using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal Journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        bool Running = true;

        while (Running)
        {
            Console.WriteLine("Write a new entry? [1]");
            Console.WriteLine("Display the Journal [2] ");
            Console.WriteLine("Save the Journal to a file [3] ");
            Console.WriteLine("Load a Jornal from a file [4] ");
            Console.WriteLine("Quit [5] ");
            Console.WriteLine("Hello, what would you like to do? 1-5? ");
            string valueFromUser = Console.ReadLine(); 

            switch (valueFromUser)
            {
                case "1":
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine($"{prompt}");
                    Console.Write("shh its a journal -");
                    string response = Console.ReadLine();

                    string date = DateTime.Now.ToShortDateString();
                    dailyEntry dailyentry = new dailyEntry(date, prompt, response);
                    Journal.AddEntry(dailyentry);
                    break;

                case "2":
                    Journal.DisplayEntries();
                    break;

                case "3":
                    Console.Write("Enter Filename");
                    Journal.SaveToFile(Console.ReadLine());
                    break;

                case "4":
                    Console.Write("Enter Filename: ");
                    Journal.LoadFromFile(Console.ReadLine());
                    break;

                case "5":
                    Running = false;

                    break;
            }

        }

    }
}

/*
basic menu use a switch  
basic switch    
 case "1":   COLON not SEMICOLON 
 code between
 break;

 case "2" 
 code between
 break;
 etc...







*/

// using (StreamWriter outputFile = new StreamWriter(myJournal.txt))




/*  need at least 1 more class in its own name.  maybe goals and a end date wth a countdown? or reminder each day to achieeve said goal.
or a spending/budget part that says have x cash save x to equal x. or tyring to save for x item, need x. wehre we at? what did we spend
 that we didn't need to?
 
write a new entry with date 
display journal  all of them   (list of entrys) 
provide a menu 
list of prompts  at least 5 diff prompts 
how does program end   
  1 load journal.txt   list of all w/ date stamp  w/ entry and pass    class journal 
  2 add entry            class   give date and a prompt to write 
  3 list and show entrys 
  5 save entry 
  6 quit program

random prompt  

classes    journal  entry  prompt generator     

journal  
list of entrys 
add, display all save, load    (list of entry objects)

entry 
date  prompt   answer/entry    (date is a string, prompts string, answer list) 
display

prompt generator
prompt list (of question strings  did you do good today,  waht did you do for another,  who did you help,  did yo ufeel the spirit today, did you share gospel)
get random prompt  string


  in this program  it makes people then saves thier name to a afile like this 
 to save to a file  

 SaveToFile(people);
 
 public static void SaveToFile(List<Person> people )
 { 
 string filename = people.txt";
 
 using StreamWriter outputFile = new StreamWriter(filename))   
 {
    foreach (Person p in people)
    {
        outputFile.WriteLine(p.firstName);     //like writeingto console but instead writes to file
    }
 }
 
 }
 
// the streamwriter makessure its open and shut at end

im lead next week 

 */

