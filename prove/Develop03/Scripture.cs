class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    private Random _random = new Random();
    private bool _allHidden;

    public Scripture(Reference reference, string text) {
      _reference = reference;
      WordsFromText(text);
      _allHidden = false;
    }
    
    private void  WordsFromText(string text) {
      String[] wordList =  text.Split(" ");

      foreach (string element in wordList)
        {
            _words.Add(new Word(element));
        }

    }

    public void Display() {
      string text = $"{_reference.GetReference()}";
      _allHidden = true;
      
      foreach (Word word in _words) {

            text += $" {word.GetWord()}";
            if(word.IsVisible()) _allHidden = false;
        }

      if (!_allHidden) Console.WriteLine(text);
    }


    public void hideRandomWord(){
      int index = _random.Next(_words.Count);
      _words[index].SetVisibility(false);
    }

    public bool AllHidden(){
      return _allHidden;
    }

}