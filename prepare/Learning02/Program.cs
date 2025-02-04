using System;

class Program
{
    static void Main(string[] args)
    {
        Resume theResume = new Resume();
        bool running = true;
        while (running) {
            displayMenu();
            Console.Write("Enter choice: ");
            string choice = Console.ReadLine();

            if (choice == "1") {
                Console.Write("What is the name of the company? ");
                string company = Console.ReadLine();

                Console.Write("What is the position? ");
                string position = Console.ReadLine();

                Job newJob = new Job();
                newJob._company = company;
                newJob._jobTitle = position;
                newJob._startYear = 2015;
                newJob._endYear = 2025;

                theResume._jobs.Add(newJob);

            }
            else if (choice == "2") {
                theResume.Display();
            }
            else if (choice == "3") {
                //Quit
                running = false;
                
            }
            else {
                Console.WriteLine("Sorry, that is not valid. Please try again.");
            }

        }

        static void displayMenu() {
            Console.WriteLine("Menu: ");
            Console.WriteLine(" 1. Add new job");
            Console.WriteLine(" 2. Display resume");
            Console.WriteLine(" 3. Quit");
            Console.WriteLine();
        }
        
        // Job job1 = new Job();
        // job1._jobTitle = "Software Engineer";
        // job1._company = "Microsoft";
        // job1._startYear = 1998;
        // job1._endYear = 2010;

        // Job job2 = new Job();
        // job2._jobTitle = "Janitor";
        // job2._company = "Country Cleaners";
        // job2._startYear = 2020;
        // job2._endYear = 2022;

        // Resume resume1 = new Resume();
        // resume1._name = "John Sorensen";
        // resume1._jobs.Add(job1);
        // resume1._jobs.Add(job2);

        // // Console.WriteLine(resume1._jobs[0]._jobTitle);

        // resume1.Display();
    }
}