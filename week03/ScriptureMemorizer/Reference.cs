public class Reference
{
    // These are attributes
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    // These are Constructors
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = -1;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }

    // This is a method
    public string GetDisplayText()
    {
        if (_endVerse == -1)
        {    
            return $"{_book} {_chapter}:{_verse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_endVerse}";
        }
    }
}