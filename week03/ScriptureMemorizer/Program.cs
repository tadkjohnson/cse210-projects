using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        Reference reference = new Reference(" 1 Nephi", 3, 7, 7);

        string text = "And it came to pass that I, Nephi, said unto my father. I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they ma yaccomplish the thing which he commandeth him";

        Scripture scripture = new Scripture(reference, text);

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.Write("Press enter to hide 3 words, ortype [quit] to exit: ");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);

            if (scripture.AllWordsHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                break;

            }

        }

    }
}

/*

In program class to get book/chapter/verse   
prompt for script prompt for # of words to hide 
code in specific scripture  or ask for one 

collects input 


classes   scripture  reference 

8 as functions 


Word stores word  if its set display or hidden and 
Reference book chapter verse  start and ending 

Hider would have to reference others 

Display  word  # of characters or the actual word



what does it do -   pulls a scripture hides words as you try to memorize it. 
inputs does it have -  return and quit
output.  display a scripture w/ words that are disappearing w/ each enter pushed
end.   quit or 100% of word erased

hider.  use?   find out what it is..

script.  use 1, not sure how to pull in more than 1. 


class behaviors 

classes     script   word  and reference    
script  hiderandomwords  get display text   use compeltelyhidden as a bool
word   hide show is hidden and get display text

reference  get displaytext as a string

use get/set   and private 

hints from team meeting
Data type for the reference is reference    data type would be List<word>  wlist of word objects rather than a list of strings.
Word class   store the text of the word itself a string  and a variable to indicate wether that word is hidden or showing  Boolean
Reference  store a variable for the book (string)  the chapter(int) and the verse (int)  



*/