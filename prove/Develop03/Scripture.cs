using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;


public class Scripture
{
    //Attributes
    private Reference _reference;
    private List<Word> _words1 = new List<Word>();
    private List<Word> _words2 = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        //split text into words
        string[] textArray = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        
        foreach (string wordContent in textArray)
        {
            //create word instance for each word
            Word word1 = new Word(wordContent);
            Word word2 = new Word(wordContent);
            //and add to _words list
            _words1.Add(word1);
            _words2.Add(word2);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        if (!_words1[numberToHide].IsHidden())
        {
            _words1[numberToHide].Hide();
        }
    }

    //This method is the additional feature I made. 
    //If you input 'show' in console, this method will be called.
    public void ShowRandomWords(int numberToShow)
    {
        if (_words1[numberToShow].IsHidden())
        {
            _words1[numberToShow].Show(_words2[numberToShow].GetDisplayText());
        }
    }

    public string GetDisplayText()
    {
        //add every word and space to text
        string text = "";
        foreach (Word word1 in _words1)
        {
            text += word1.GetDisplayText();
            text += " ";
        }
        return _reference.GetDisplayText() + text;
    }

    public bool IsCompletelyHidden()
    {
        //determine if every words contain '_'
        foreach (Word word in _words1)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}