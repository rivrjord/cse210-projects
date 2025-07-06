using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");

        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2010;
        job1._endYear = 2019;
        job1.DisplayJobDetails();

        Job job2 = new Job();
        job2._jobTitle = "Data Analyst";
        job2._company = "Apple";
        job2._startYear = 2010;
        job2._endYear = 2019;
        job2.DisplayJobDetails();

        Resume myResume = new Resume();
        myResume._name = "Lawrence Okon";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        Console.WriteLine("First job title: " + myResume._jobs[0]._jobTitle);

        myResume.Display();
    }
}