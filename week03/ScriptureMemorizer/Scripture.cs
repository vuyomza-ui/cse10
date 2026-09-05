using System;
using System.Collections.Generic;

// Represents the entire scripture.
public class Scripture

{
    private Reference _reference;
    private List<Word> _words;
    private Random _random;

    // Constructor.
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        _random = new Random();
        
        
    string[] words = text.Split(
        new[] {' ', '\n', '\r', '\t' },
        StringSplitOptions.RemoveEmptyEntries
    );

    foreach (string word in words)
    {
        _words.Add(new Word(word));
    }

    }

    public string GetDisplayText()
    {
        string display = _reference.GetDisplayText() + "\n";

        foreach (Word word in _words)
        {
            display += word.GetDisplayText() + " ";
        }

        return display.Trim();
    }

    public void HideRandomWords(int numberOfWords)
    {
        int wordsHidden = 0;

        while (wordsHidden < numberOfWords && !IsCompletelyHidden())
        {
            int index = _random.Next(_words.Count);

            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                wordsHidden++;
            }
        }
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }

        return true;
    }
}