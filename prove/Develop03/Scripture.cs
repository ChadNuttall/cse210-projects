using System;

class Scripture
{
    private string _scriptureText; // Encapsulate the scripture text

    public Scripture(string scriptureText)
    {
        _scriptureText = scriptureText;
    }

    public override string ToString() // Use ToString to return formated message inclucing all portions of the scripture
    {
        return $"{_scriptureText}";
    }
}