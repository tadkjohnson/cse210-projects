using System;
using System.Collections.Generic;
public class PromptGenerator
{
    public List<string> _prompts = new List<string>
    {
        "What did I do today that I want to reflect on?",
        "What would I want my children to know of today?",
        "What did I learn today",
        "What was something I helped someone else with today?",
        "Why was today important to me?",
        "What today could I learn from to better prepare me for the future?",
        "What is my Favorite Color? Are you sure?"
        };

    public Random _random = new Random();
    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }
}








