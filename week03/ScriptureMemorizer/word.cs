using System;
using System.Collections.Concurrent;
using System.Linq;

class words

{
    private string _text;
    private bool _isHidden;

    public words(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void hide()
    {
        _isHidden = true;
    }
    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        if (_isHidden)
        {
            return new string('_', _text.Length);
        }
        else
        {
            return _text;
        }
    }
}
