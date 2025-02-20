using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Isaac Edwards", "Multiplication");
        Console.WriteLine(assignment1.GetSummary());

        MathAssignment mathAssignment1 = new MathAssignment("Josh Edwards", "Division", "7.5", "12-15");   
        Console.WriteLine(mathAssignment1.GetSummary());
        Console.WriteLine(mathAssignment1.GetHomeworkList());

        WritingAssignment writingAssignment = new WritingAssignment("John Doe", "Fractions", "How to Divide Like a Pro");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}