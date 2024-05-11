public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = new Reference("Proverbs", 3, 5, 6);
        string[] words = text.Split(" ");
        foreach (string word in words)
        {
            Word wordFromText = new Word(word);
            _words.Add(wordFromText);
        }
    }

    public bool HideRandomWord(int numberToHide)
    {
        if (_words[numberToHide].IsHidden() == false)
        {
            _words[numberToHide].Hide();
            return true;
        }
        return false;
    }

    public string GetDisplayText()
    {
        string text = _reference.GetDisplayText() + " ";
        foreach (Word word in _words)
        {
            text += word.GetDisplayText() + " ";
        }
        return text.Trim();
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (word.IsHidden() == false)
            {
                return false;
            }
        }
        return true;
    }
}