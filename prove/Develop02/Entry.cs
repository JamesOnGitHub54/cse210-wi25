public class Entry
{
    public string _date;
    public string _prompt;
    public string _text;

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt}\n{_text}");
    }
}