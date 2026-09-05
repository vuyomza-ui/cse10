using System

public class Comment

{
    private string _name;
    private string _text;

    // Constructor.
    public Comment(string name, string text)
    {
        _name = name;
        _text = text;
    }

    // Returns the comment information.
    public string GetDisplayText()
    {
        return $"{_name}: {_text}";
    }
    
}
