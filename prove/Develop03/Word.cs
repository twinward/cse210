using System;
using System.Collections.Generic;

class Word
{
    private string _text;
    private bool _isHidden;

    // Constructors:
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    // Methods:

    public void Hide()
    {
        _isHidden = true;
    }

    public string GetDisplayText()
    {
        if (_isHidden == true)
        {
            return "_____";
        }
        else
        {
            return $"{_text}";
        }
    }

    public bool GetIsHidden()
    {
        if(_isHidden == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }


}