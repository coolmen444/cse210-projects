using System;

class Program
{
    static void Main(string[] args)
    {
        bool isRunning = true;
        BreathingActivity breather = new BreathingActivity();
        ListingActivity lister = new ListingActivity();
        ReflectingActivity reflector = new ReflectingActivity(); 

        while (isRunning)
        {

            Console.WriteLine("Menu Options:");
            Console.WriteLine("   1. Breathing Activity");
            Console.WriteLine("   2. Reflecting Activity");
            Console.WriteLine("   3. Listing Activity");
            Console.WriteLine("   4. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                breather.Run();
            }
            else if (choice == "2")
            {
                reflector.Run();
            }
            else if (choice == "3")
            {
                lister.Run();
            }
            else if (choice == "4")
            {
                isRunning = false;
            }
            else
            {
                Console.WriteLine("Please choose a number 1 - 4");
            }
                
        }
    }
}