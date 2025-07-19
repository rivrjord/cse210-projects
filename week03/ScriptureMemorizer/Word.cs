public class Word
{
    // These are the attributes
    private string _text;
    private bool _isHidden;

    // Constructor
    public Word (string text)
    {
        _text = text;
        _isHidden = false;
    }
    
    // These are the behaviors
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
        return _isHidden? new string('_', _text.Length) : _text;
    }
}    

