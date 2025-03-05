using System;

class Program
{
    static void Main(string[] args)
    {

        Job job1 = new Job("Software Engineer", "Microsoft", 2000, 2020);

        Job job2 = new Job("Software Developer", "APPLE", 1980, 2024);

        Resume JobResume = new Resume("Joe");
        JobResume.addJob(job1);
        JobResume.addJob(job2);

        JobResume.DisplayResume();
        

    }
}
