public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }
    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }
    public string GetDisplayText()
    {
        int characterQuantity = _text.Length;
        if (_isHidden == true)
        {
            string characterHidden = new string('_', characterQuantity);
            return characterHidden;
        }
        else
        {
            return _text;
        }
    }
}