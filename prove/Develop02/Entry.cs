public class Entry
{
    public string _date;
    public string _prompt;
    public string _response;

    public string ReturnEntry()
    { 
        return $"{_date} - Prompt: {_prompt} \n {_response}\n";
    }

     public void SetEntry(string prompt, string response)
    {
        _date = DateTime.Now.ToString("MM-dd-yyyy");
        _prompt = prompt;
        _response = response;
    }

    public void SetEntry(string prompt, string response, string date)
    {
        _date = date;
        _prompt = prompt;
        _response = response;
    }
}