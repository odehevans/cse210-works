using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Developer";
        job1._company = "Microsoft";
        job1._startYear = 2003;
        job1._endYear = 2023;

        Job job2 = new Job();
        job2._jobTitle = "Fullstack Developer";
        job2._company = "Apple";
        job2._startYear = 2010;
        job2._endYear = 2020;

        Resume resume = new Resume();
        resume._name = "Falz Maco";

        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.Display();
    }
}