using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

class Scripture
{
    private Reference _reference;
    private List<Words> _Words;
    private Random _random = new Random();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _Words = new List<Words>();

        foreach (string wordText in text.Split(" "))
        {
            _Words.Add(new Words(wordText));
        }
    }

    public string GetDisplayText()
    {
        string wordsText = string.Join(" ", _Words.Select(w => w.GetDisplayText()));
        return $"{_reference.GetDisplayText()}\n{wordsText}";
    }

    public void HideRandomWords(int count)
    {

        List<Words> visibleWords = _Words.Where(w => !w.IsHidden()).ToList();
        for (int i = 0; i < count && visibleWords.Count > 0; i++)

        {
            int index = _random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }
    public bool AllWordsHidden()
    {
        return _Words.All(w => w.IsHidden());
    }
}






// "And it came to pass that I, Nephi, said unto my father. I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they ma yaccomplish the thing which he commandeth him"
