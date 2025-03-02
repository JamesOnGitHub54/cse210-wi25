using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Journal Program!");
        int choice = 1;

        while (choice <4)
        {
            Console.Write(@"Menu Options:
    1. Start Breathing Activity
    2. Start Reflection Activity
    3. Start Listening Activity
    4. Quit
Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                Breathing.BreathingMessage(Breathing._name, Breathing._message);
                Breathing.BreathingActivity();
            }
            else if (choice == 2)
            {

            }
            else if (choice == 3)
            {
                
            }
            else if (choice == 4)
            {
                Console.WriteLine("Thank you! Until next time!");
            }
        }
    }
}