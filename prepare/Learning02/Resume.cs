using System;

public class Resume
{
    private string _personName;
    private List<Job> _jobs = new List<Job>();

    public Resume(string personName, List<Job> jobs)
    {
        _personName = personName;
        _jobs = jobs;
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

}