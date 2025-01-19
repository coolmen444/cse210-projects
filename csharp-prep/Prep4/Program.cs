using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numberList = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        bool continueLoop = true;
        int lowestNumber = 2147483647;
        int highestNumber = -2147483647;

        while (continueLoop) {
            Console.Write("Enter number: ");
            int newNumber = int.Parse(Console.ReadLine());

            if (newNumber == 0) {
                continueLoop = false;
            }
            else {
                numberList.Add(newNumber);
            }

            if (newNumber < lowestNumber && newNumber > 0) {
                lowestNumber = newNumber;
            }
            if (newNumber > highestNumber) {
                highestNumber = newNumber;
            }
        }

        int sum = 0;
        foreach (int number in numberList) {
            sum += number;
        }

        float average = (float)sum / numberList.Count;
        numberList.Sort();
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {Math.Round(average, 3)}");
        Console.WriteLine($"The largest number is: {highestNumber}");
        Console.WriteLine($"The smallest positive number is: {lowestNumber}");
        Console.WriteLine("The sorted list is:");

        foreach (int number in numberList) {
            Console.WriteLine(number);
            
        }
    }
}