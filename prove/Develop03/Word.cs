public class Word 
{
    private string _text;
    private int _index;
    private bool _isHidden;

    public Word(string text, int index) 
    {
        _text = text;
        _index = index;
        _isHidden = false;
    }

    public string GetDisplayContent() 
    {
        return _text;
    }

    public void Hide() 
    {
        string wordUnderscores = "";
        foreach (char letter in _text) {
            wordUnderscores += "_";
        }
        _isHidden = true;
        _text = wordUnderscores;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

  

}