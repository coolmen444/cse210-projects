public class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;

    public Reference(string book, int chapter, int verse) 
    {
        _book = book;
        _chapter = chapter;
        _startVerse = verse;
        _endVerse = verse;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    public string GetDisplayContent() 
    {
        if (_startVerse == _endVerse)  
        {
        return $"\u001b[33m{_book} {_chapter}:{_startVerse}\u001b[0m";
        }
        else 
        {
        return $"\u001b[33m{_book} {_chapter}:{_startVerse}-{_endVerse}\u001b[0m";
        }
    }
}