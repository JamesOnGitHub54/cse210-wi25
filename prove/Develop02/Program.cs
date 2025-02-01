using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        int choice;

        do
        {
            Console.Write(@"Please select one of the following choices:
1. Write
2. Display
3. Load
4. Save
5. Quit
What would you like to do? ");
            ///choices here
            choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {

            }
            else if (choice == 2)
            {

            }
            else if (choice == 3)
            {
                
            }
            else if (choice == 4)
            {
                
            }
            else if (choice == 5)
            {
                Console.WriteLine("Bye");
            }





        }
        while (choice != 5);



        /// 1 create an entry object to pass to the journal for storage

        //Entry e = new Entry();
        //e.Display();
    }
}