using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage: ");
        float percentage = float.Parse(Console.ReadLine());
        string letter = "";
        bool passed = true;

        if (percentage >= 90) {
            letter = "A";
        }
        else if (percentage >= 80) {
            letter = "B";
        }
        else if (percentage >= 70) {
            letter = "C";
        }
        else if (percentage >= 60) {
            letter = "D";
        }
        else if (percentage < 60) {
            letter = "F";
        }
        else {
            letter = "ERROR";
        }

        if (percentage >= 70) {
            passed = true;
        }
        else {
            passed = false;
        }

        Console.WriteLine($"Your letter grade is: {letter}");

        if (passed) {
            Console.WriteLine("Congratulations, you have passed!");
        }
        else {
            Console.WriteLine("You did not pass, but don't give up!");
        }
    }
}