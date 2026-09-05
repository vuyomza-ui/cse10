using System;

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    // Hides the word.
    public void Hide()
    {
        _isHidden = true;
    }

    // Returns whether the word is currently hidden
    public bool IsHidden()
    {
        return _isHidden;
    }

    // Returns either the original word or underscores.
    public string GetDisplayText()
    {
        if (_isHidden)
        {
            return new string('_', _text.Length);
        }

        return _text;
    }
}