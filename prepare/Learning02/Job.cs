public class Job
{
    private string _company;
    private string _jobTitle;
    private int _startYear;
    private int _endYear;

    public Job(string jobTitle, string companyName, int startYear, int endYear)
    {
        _company = companyName;
        _jobTitle= jobTitle;
        _startYear= startYear;
        _endYear = endYear;

    }

    public void DisplayJobInfo()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}