using System;

class Program
{
    static void Main(string[] args)
    {
        // Create and populate the first job object
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        // Create and populate the second job object
        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;

        // Create the master Resume Object
        Resume myResume = new Resume();
        myResume._name = "Allison Rose";

        // Layer the object by adding the jobs into the resume list
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        // Execute the clean abstraction display
        myResume.Display();
        
    }
    
}