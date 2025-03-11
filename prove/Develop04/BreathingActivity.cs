public class BreathingActivity : Activity
{
    public BreathingActivity() : base("This activity will help you relax by walking through breathing in and out slowly. Clear your mind and focus on your breathing.", "Breathing Activity")
    {
       
    }
    
    public void Run()
    {
        DisplayStartMessage();

        int cycles =  _time / 10;
        int extraTime = _time % 10;
        int halfExtraTime = extraTime / 2;
        int extraHalf = (int)Math.Ceiling(extraTime / 2.0);
        
        if (extraHalf != 0)
        {
        Console.Write("\nBreathe in...");
        Countdown(halfExtraTime);
        Console.WriteLine();
        Console.Write("Now breathe out...");
        Countdown(extraHalf);
        }
  

        for (int i = 0; i < cycles; i++)
        {
            Console.Write("\n\nBreathe in...");
            Countdown(4);
            Console.WriteLine();
            Console.Write("Now breathe out...");
            Countdown(6);
        }

        DisplayEndMessage();
    }


}