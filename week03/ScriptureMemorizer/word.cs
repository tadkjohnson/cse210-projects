using System;
using System.Collections.Concurrent;
using System.Linq;

class Words

{
    private string _text;
    private bool _isHidden;
    private bool _hidden;

    public Words(string text)
    {
        _text = text;
        _isHidden = false;
        _hidden = false;
    }

    public void Hide()
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
