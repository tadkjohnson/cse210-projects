using System;

public class dailyEntry
{
    // DateTime theCurrentTime = DateTime.Now;

    public string _prompt;
    public string _response;
    public string _date;
    //public DateTime theCurrentTime.ToShortDateString();

    // makes public private to be used elsewhere - test the change to public
    public dailyEntry(string date, string prompt, string response)

    {
        _date = date;
        _prompt = prompt;
        _response = response;
    }


    public void Display()

    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Response: {_response}");
        Console.WriteLine();

    }
    // builds the list with seperator to read it back later from and to save
    public string ToFileString()
    {
        return $"{_date}~{_prompt}~{_response}";
    }
    // load parts removes seperator to make it look less messy
    public static dailyEntry FromFileString(string line)
    {
        string[] parts = line.Split("~");
        return new dailyEntry(parts[0], parts[1], parts[2]);
    }

}
