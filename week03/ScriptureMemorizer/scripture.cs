using System;
using System.Collections.Concurrent;
using System.Linq;

class Scripture
{
    private Reference _reference;
    private List<words> _words;
    private Random _random = new Random();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<words>();

        foreach (string word in text.Split(" "))
        {
            words.Add(new words(word));
        }
    }

    public string GetDisplayText()
    {
        string wordsText = string.Join(" ", _words.Select(w => w.GetDisplayText()));
        return $"{_reference.GetDisplayText()}\n{wordsText}";
    }

    public void HideRandomWords(int count)
    {

    }
}



"And it came to pass that I, Nephi, said unto my father. I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they ma yaccomplish the thing which he commandeth him"
