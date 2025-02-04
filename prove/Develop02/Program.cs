using System;
using System.IO; 

class Program
{
    static void Main(string[] args)
    {
        PromptGenerator promptGenerator = new PromptGenerator();
        Journal journal = new Journal();
        QuoteGenerator quoteGenerator = new QuoteGenerator();

        bool isRunning = true;
            string quote = quoteGenerator.ReturnQuote();
            Console.WriteLine($"\"{quote}\"");
            Console.WriteLine();

        while (isRunning) {
            DisplayMenu();
            string choice = Console.ReadLine();

            if (choice == "1") {
                Entry entry = new Entry();
                string prompt = promptGenerator.ReturnPrompt();
                Console.WriteLine(prompt);
                Console.Write("> ");
                string response = Console.ReadLine();
                entry.SetEntry(prompt, response);
                journal.AddEntry(entry);


            }
            else if (choice == "2") {
                foreach (Entry entry in journal._entries) {
                    Console.WriteLine(entry.ReturnEntry());
                }
                
            }

            else if (choice == "3") {
                journal.LoadJournal();
            }

            else if (choice == "4") {
             journal.SaveJournal();
            }

            else if (choice == "5") {
                isRunning = false;
            }
        }
    }

    static void DisplayMenu() {
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write("What would you like to do? ");
    }
}