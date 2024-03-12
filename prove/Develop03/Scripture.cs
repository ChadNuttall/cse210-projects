using System;

class Scripture
{
    private string _book, _chapter, _verse, _scriptureText;

    public Scripture(string book, string chapter, string verse, string scriptureText)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _scriptureText = scriptureText;
    }

    public override string ToString()
    {
        return $"{_book} {_chapter}:{_verse} {_scriptureText}";
    }
}