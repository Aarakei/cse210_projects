using System.ComponentModel.DataAnnotations;

class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private List<int> _shownWordIndices;

    public Scripture(string book, int chapter, int verse, string passage)
    {
        _reference = new Reference(book, chapter, verse);
        TurnVerseIntoWords(passage);
        
    }
    public Scripture(string book, int chapter, int startVerse, int endVerse, string passage)
    {
        _reference = new Reference(book, chapter, startVerse, endVerse);
        TurnVerseIntoWords(passage);
    }

    private void TurnVerseIntoWords(string passage)
    {
        _words = new List<Word>();
        _shownWordIndices = new List<int>();
        int i = 0;
        foreach (string word in passage.Split())
        {
            _words.Add(new Word(word));
            _shownWordIndices.Add(i);
            i++;
        }
    }

    public void HideWords(int numberToHide = 3)
    {
        if(_shownWordIndices.Count() <= numberToHide)
        {
            for (int i = 0; i < _shownWordIndices.Count(); i++)
            {
                _words[_shownWordIndices[i]].Hide();
            }
            _shownWordIndices.Clear();
        }
        else
        {
            Random numberGenerator = new Random();
            for (int i = 0; i < numberToHide; i++)
            {
                int indexToHide = numberGenerator.Next(0,_shownWordIndices.Count());
                _words[_shownWordIndices[indexToHide]].Hide();
                _shownWordIndices.RemoveAt(indexToHide);
            }
        }
    }

    public void ShowAllWords()
    {
        _shownWordIndices.Clear();
        int i = 0;
        foreach(Word word in _words)
        {
            word.Show();
            _shownWordIndices.Add(i);
            i++;
        }
    }

    public bool HasWordsRemaining()
    {
        if (_shownWordIndices.Count > 0)
        {
            return true;
        }

        return false;
    }

    public string GetReference()
    {
        return _reference.GetReference();
    }

    public void Display()
    {
        _reference.Display();
        foreach(Word word in _words)
        {
            word.Display();
        }
        Console.WriteLine();
    }
}