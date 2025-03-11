public class ListingActivity : Activity
{
    private List<string> _promptList = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", "Listing Activity")
    {
       
    }
    public void Run()
    {
        DisplayStartMessage();

        Console.WriteLine("List as many responses you can to the following prompt:");
        Random random = new Random();
        Console.WriteLine($"--- {_promptList[random.Next(0, _promptList.Count)]} ---\n"); 

        Console.Write("You may begin in: ");
        Countdown(5);
        Console.WriteLine();
        DateTime endTime = DateTime.Now.AddSeconds(_time);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
        }

        DisplayEndMessage();
    }
}