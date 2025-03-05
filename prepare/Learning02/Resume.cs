using System;

public class Resume
{
    private string _personName;
    private List<Job> _jobs;

    public Resume(string personName)
    {
        _personName = personName;
        _jobs = new List<Job>();
    }
    
    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_personName}");
        Console.WriteLine("Jobs:");
        foreach (Job job in _jobs)
        {
        job.DisplayJobInfo();
        }
    }
    
    public void addJob(Job job)
    {
        _jobs.Add(job);
    }

}