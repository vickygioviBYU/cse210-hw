using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2020;
        job1._endYear = 2023;

        // Console.WriteLine(job1._company);

        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Programmer";
        job2._startYear = 2015;
        job2._endYear = 2020;

        // Console.WriteLine(job2._company);

        // job1.DisplayJobDetails();
        // job2.DisplayJobDetails();

        Resume resume1 = new Resume();
        resume1._name = "Giovanni Canavesi";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        // Console.WriteLine(resume1._jobs[0]._jobTitle);

        resume1.Display();
    }
}