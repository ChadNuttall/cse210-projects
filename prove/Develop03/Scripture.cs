using System;

class Scripture
{
    private string _book, _chapter, _verse, _scriptureText; // Encapsulate each portion of the scripture

    public Scripture(string book, string chapter, string verse, string scriptureText)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _scriptureText = scriptureText;
    }

    public override string ToString() // Use ToString to return formated message inclucing all portions of the scripture
    {
        return $"{_book} {_chapter}:{_verse} {_scriptureText}";
    }
}