public class Activity{
    public string _name;
    public string _message;
    public int _session;

    public Activity(string _arg_name, string _argMessage, int _argSession)
    {
        _name = _arg_name;
        _message = _argMessage;
        _session = _argSession;
        Console.WriteLine($"Store for {_name}\n");

    }

    public static void Animation(){
        Console.Write("|");
        Thread.Sleep(500);
        Console.Write("\b \b"); // Erase the + character
        Console.Write("/"); // Replace it with the - character
        Thread.Sleep(500);
        Console.Write("\b \b"); // Erase the + character
        Console.Write("-"); // Replace it with the - character
        Thread.Sleep(500);
        Console.Write("\b \b"); // Erase the + character
        Console.Write("\\"); // Replace it with the - character
        Thread.Sleep(500);
        Console.Write("\b \b"); // Erase the + character

    }




}