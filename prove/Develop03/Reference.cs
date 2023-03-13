class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference(string book, int chapter, int verse) {
      _book = book;
      _chapter = chapter;
      _verse = verse;
      _endVerse = 0;
    }
    public Reference(string book, int chapter, int verse, int endVerse) {
      _book = book;
      _chapter = chapter;
      _verse = verse;
      _endVerse = endVerse;
    }

    public string GetReference() {
      string reference = $"{_book} {_chapter}:{_verse}";
      if (_endVerse > 0) reference = reference + $"-{_endVerse}";
      return reference;
    }
}