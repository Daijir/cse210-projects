using System;

public class Reference
{
    //Attributes
    private string _book;
    private int _chapter;
    private int _verse;
    private int? _endVerse;

    public Reference(string book, int chapter, int verse)
    {
        //set each variables
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    //override of Reference method  
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        //set each variables
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }

    public string GetDisplayText()
    {
        //Determine if a _endVerse has a value;
        if (!_endVerse.HasValue)
        {
            return $"{_book} {_chapter}:{_verse} ";
        }

        else
        {
            return $"{_book} {_chapter}:{_verse} - {_endVerse} ";
        }
    }

}