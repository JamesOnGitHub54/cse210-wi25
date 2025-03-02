public class Breathing(){
    public int _breathIn;
    public int _breathOut;

    
    public static string _name = "Breathing Activity";
    public static string _message = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind adn focus on your breathing";

    public static void BreathingMessage(string _name, string _message)
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}\n{_message}");
        Console.WriteLine("How Long? ");
        int _session = int.Parse(Console.ReadLine());

    }

    public static void BreathingActivity(){
        Console.Clear();
        Console.WriteLine("Get Ready...");
        for (int i = 0; i < 2; i++){
            Activity.Animation();
        }

        Console.Write("\nBreath in... 3");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("2");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("1");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.WriteLine();

    }

}