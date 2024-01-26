using System;
using System.Text.RegularExpressions;

public class Word 
{
    //Attributes
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        //set text
        _text = text;
    }

    public void Hide()
    {
        //change the word into '___'
        int length = _text.Length;
        _text = new string('_', length);
    }

    public void Show(string restoredText)
    {
        //Additional freature
        _text = restoredText;
    }

    public bool IsHidden()
    {
        //Determine if the word contains '_'
        Regex regex = new Regex("[_]");
        _isHidden = regex.IsMatch(_text);
        return _isHidden;
    }

    public string GetDisplayText()
    {
        //get the word
        return _text;
    }
}