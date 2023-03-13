class Word
{
    private string _word;
    private bool _visible;

    public Word(string word) {
      _word = word;
      _visible = true;
    }

    public string GetWord() {
      if (_visible) return _word;
      return new string('_', _word.Length);
    }

    public bool IsVisible(){
      return _visible;
    }

    public void SetVisibility(bool visible) {
      _visible = visible;
    }
}