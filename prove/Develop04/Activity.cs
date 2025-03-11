public class Activity
{
    protected string _name;
    protected string _description;
    protected int _time;

    public Activity(string description, string name)
    {
        _name = name;
        _description = description;
        
    }

    public void DisplayStartMessage() 
    {
        Console.Clear();
        Console.WriteLine($"Hello, welcome to the {_name} activity");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();

        bool validInput = false;

        while (!validInput)
        {
        Console.Write("How long, in seconds, would you like for your session? ");
        _time = int.Parse(Console.ReadLine());

        if (_time > 0) {
            validInput = true;
        }
        else {
             Console.WriteLine("Time must be greater than 0. Please enter a new value.");
        }
        
        }

        Console.Clear();
        Console.WriteLine("Get Ready...");
        DisplaySpinner(3);
        Console.WriteLine();
    }

    public void DisplaySpinner(int seconds)
    {
        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        while (DateTime.Now < endTime)
        {
            Console.CursorVisible = false;
            Console.Write("/");
            Thread.Sleep(200);
            Console.Write("\b");
            Console.Write("-");
            Thread.Sleep(200);
            Console.Write("\b");
            Console.Write("\\");
            Thread.Sleep(200);
            Console.Write("\b");
            Console.Write("|");
            Thread.Sleep(200);
            Console.Write("\b \b");

        }
        Console.CursorVisible = true;
    }

    public void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.CursorVisible = false;
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.CursorVisible = true;
        }
    }

    public void DisplayEndMessage()
    {
       Console.WriteLine("\n\nWell done!!");
        DisplaySpinner(3);
        Console.WriteLine($"\nYou have completed another {_time} seconds of the {_name} Activity.");
        DisplaySpinner(2);
        Console.Clear();
    }

}