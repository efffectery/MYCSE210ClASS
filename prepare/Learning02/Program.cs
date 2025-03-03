using System;

class Program
{
    static void Main(string[] args)
    {

        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = "2000";
        job1._endYear = "2020";

        Job job2 = new Job();
        job2._jobTitle = "Software Developer";
        job2._company = "APPLE";
        job2._startYear = "1980";
        job2._endYear = "2024";
        
        Resume JobResume = new Resume();
        JobResume._personName = "Joe";

        JobResume._jobs.Add(job1);
        JobResume._jobs.Add(job2);

        JobResume.DisplayResume();
        

    }
}
