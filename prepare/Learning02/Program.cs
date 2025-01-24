using System;

class Program
{
    static void Main(string[] args)
    {
        //Add new Jobs.
        Job job1 = new Job();
        job1._title = "Quality Assurance";
        job1._company = "Samsung";
        job1._startYear = 2022;
        job1._endYear = 2025;

        Job job2 = new Job();
        job2._title = "Customer Support";
        job2._company = "Intel";
        job2._startYear = 2020;
        job2._endYear = 2022;

        Job job3 = new Job();
        job3._title = "Janitor";
        job3._company = "Google";
        job3._startYear = 2009;
        job3._endYear = 2025;


        //Add Resumes.
        Resume resume1 = new Resume();
        resume1._name = "Bobby Junior";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        Resume resume2 = new Resume();
        resume2._name = "Dale Senior";
        resume2._jobs.Add(job3);

        //Display Resumes.
        resume1.Display();
        resume2.Display();
    }
}