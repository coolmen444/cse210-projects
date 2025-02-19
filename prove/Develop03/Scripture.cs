public class Scripture 
{
    private List<Word> _wordList = new List<Word>();
    private Reference _reference;



    public Scripture(Reference reference, string scripture)
    {
        string[] words = scripture.Split(' ');

        int indexCounter = 0;
        foreach (string word in words) {
            Word newWord = new Word(word, indexCounter);
            _wordList.Add(newWord);
            indexCounter++;
        }

        _reference = reference;
    }

    public string GetDisplayContent() 
    {
        string displayContent = "";
        
        displayContent += _reference.GetDisplayContent() + " ";

        foreach (Word word in _wordList)
        {
            displayContent += word.GetDisplayContent() + " ";
        }
        return displayContent;
    }

    public List<Word> GetWordList()
    {
        return _wordList;
    }
}