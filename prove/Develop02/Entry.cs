public class Entry
{
    public string _prompt;
    public string _response;
    public string _date;

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - {_prompt}");
        Console.WriteLine($"{_response}");
    }
}