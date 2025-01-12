using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage?: ");
        int user_gp = int.Parse(Console.ReadLine());

        string letter = "";
        string message = "";
        
        //Convert grade percentage to letter grade
        if (user_gp >= 90){
            letter = "A";
        }
        else if (user_gp >= 80){
            letter = "B";
        }
        else if (user_gp >= 70){
            letter = "C";
        }
        else if (user_gp >= 60){
            letter = "D";
        }
        else letter = "F";

        //Determine passing or failing with message
        if (user_gp >= 70){
            message = "Congratulations! You have passed the course!";

        }
        else message = "Unfortunately, you did not pass. You can do it, next time!";

        Console.WriteLine($"You have earned: {letter}. {message}");

    }
}