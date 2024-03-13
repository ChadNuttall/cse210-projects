using System;

class Reference
{
    private string _book, _chapter, _verse;
    public Reference(string book, string chapter, string verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public override string ToString() // Use ToString to return formated message inclucing all portions of the Reference
    {
        return $"{_book} {_chapter}:{_verse}";
    }
}
