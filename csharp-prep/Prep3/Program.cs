using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number? ");
        int magic_number = int.Parse(Console.ReadLine());
    
        bool continueLoop = true;
        while (continueLoop) {

            Console.Write("What is your guess? ");
            int guess = int.Parse(Console.ReadLine());
            
            if (guess < magic_number) {
                Console.WriteLine("Higher");
            } 
            else if (guess > magic_number) {
                Console.WriteLine("Lower");
            }
            else if (guess == magic_number) {
                Console.WriteLine("You guessed it!");
                continueLoop = false;
            }
        }
    }
}