using System;
using System.Collections.Generic;

// Represents a scripture reference such as "John 3:16"
// or "Proverbs 3:5-6"
public class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int? _endVerse;

    // Constructor for a single verse.
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = verse;
        _endVerse = null;
    }

    // Constructor for a range of verses.
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    // Returns the formatted refeerence.
    public string GetDisplayText()
    {
        if (_endVerse.HasValue)
        {
            return $"{_book} {_chapter}:{_startVerse}-{_endVerse}"; 
        }
        
        return $"{_book} {_chapter}:{_startVerse}";
    }
}