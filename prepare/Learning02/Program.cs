using System;

class Program
{
    static void Main(string[] args)
    {
        
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 1998;
        job1._endYear = 2010;

        Job job2 = new Job();
        job2._jobTitle = "Janitor";
        job2._company = "Country Cleaners";
        job2._startYear = 2020;
        job2._endYear = 2022;

        Resume resume1 = new Resume();
        resume1._name = "John Sorensen";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        // Console.WriteLine(resume1._jobs[0]._jobTitle);

        resume1.Display();
    }
}