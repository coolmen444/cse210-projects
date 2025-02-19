using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference1 = new Reference("Moroni", 7, 45);
        Scripture scripture1 = new Scripture(reference1, "And charity suffereth long, and is kind, and envieth not, and is not puffed up, seeketh not her own, is not easily provoked, thinketh no evil, and rejoiceth not in iniquity but rejoiceth in the truth, beareth all things, believeth all things, hopeth all things, endureth all things.");
        Random random = new Random();

        bool isRunning = true;
        while (isRunning) 
        {
            Console.WriteLine(scripture1.GetDisplayContent()); 
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Press enter to continue, type 'quit' to finish: ");
            Console.ForegroundColor = ConsoleColor.White;

            string userInput = Console.ReadLine();

            if (userInput == "") {

                int visibleCount = 0;
                foreach (Word word in scripture1.GetWordList())
                {
                    if (!word.IsHidden()) 
                    {
                        visibleCount++;
                    }
                }

                if (visibleCount <= 3)
                {
                    foreach (Word word in scripture1.GetWordList())
                    {
                        if (!word.IsHidden()) {
                            word.Hide();
                        }
                    }
                    if (visibleCount == 0)
                    {
                        isRunning = false;
                    }
                    continue;
                }
                

                int randomIndex1 = random.Next(0, scripture1.GetWordList().Count);
                int randomIndex2 = random.Next(0, scripture1.GetWordList().Count);
                int randomIndex3 = random.Next(0, scripture1.GetWordList().Count);
                    
                
                while (scripture1.GetWordList()[randomIndex1].IsHidden()) 
                {
                    randomIndex1 = random.Next(0, scripture1.GetWordList().Count);
                }

                while (scripture1.GetWordList()[randomIndex2].IsHidden() || randomIndex2 == randomIndex1 || randomIndex2 == randomIndex3) 
                {
                    randomIndex2 = random.Next(0, scripture1.GetWordList().Count);
                }

                while (scripture1.GetWordList()[randomIndex3].IsHidden() || randomIndex3 == randomIndex1 || randomIndex3 == randomIndex2) 
                {
                    randomIndex3 = random.Next(0, scripture1.GetWordList().Count);
                }
                
            
                scripture1.GetWordList()[randomIndex1].Hide();
                scripture1.GetWordList()[randomIndex2].Hide();
                scripture1.GetWordList()[randomIndex3].Hide();

            }
            else if (userInput == "quit")
            {
                isRunning = false;
            }
            else 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("INVALID INPUT");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}