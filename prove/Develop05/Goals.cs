class Goals
{
    private List<Goal> _goals = new List<Goal>();
    private const string type1 = "CheckListGoal";
    private const string type2 = "EternalGoal";
    private const string type3 = "SimpleGoal";
    private int _points;

    public void AddGoal(Goal new_goal)
    {
        _goals.Add(new_goal);
    }
    public void DisplayGoals()
    {
        foreach(Goal goal in _goals)
        {
            goal.Display();
        }
    }
    public int CompleteAGoal()
    {
        Dictionary<int, Goal> dict = new Dictionary<int, Goal>();
        int i = 1;
        foreach(Goal goal in _goals)
        {
            dict.Add(i, goal);
            Console.Write($"{i}. "); goal.Display();
            i++;
        }

        Console.WriteLine("\nWhich number did you complete? ");
        int userinput = int.Parse(Console.ReadLine());
        if(dict.ContainsKey(userinput))
        {
            dict[userinput].RecordEvent();
        }
        _points = dict[userinput].GetPoints();
        return dict[userinput].GetPoints();
    }

    public int GetPointsFromGoals()
    { return _points; }
    public List<Goal> GetGoals()
    {
        return _goals;
    }

    public void SaveGoals()
    {
        Console.WriteLine("What should the filename be: ");
        string file_name = Console.ReadLine();
        using (StreamWriter output = new StreamWriter(file_name))
        {
            output.WriteLine($"{GetPointsFromGoals()}");
            foreach(Goal goal in _goals)
            {
                string done_symbole = "";
                if (goal.GetDone() == true)
                { done_symbole = "[X]"; }
                else
                { done_symbole = "[ ]"; }

                if (goal.GetType() == type1)
                { output.WriteLine($"{done_symbole}#{goal.GetType()}#{goal.GetName()}#{goal.GetDesript()}#{goal.GetPPC()}#{goal.GetAD()}#{goal.GetATD()}"); }
                else if (goal.GetType() == type3)
                { output.WriteLine($"{done_symbole}#{goal.GetType()}#{goal.GetName()}#{goal.GetDesript()}#{goal.GetPPC()}"); }
                else
                { output.WriteLine($"{done_symbole}#{goal.GetType()}#{goal.GetName()}#{goal.GetDesript()}#{goal.GetPPC()}"); }
            }

        }
    }
    public List<Goal> Load()
    {
        _goals = new List<Goal>();
        Console.WriteLine("What file do you want to load from: ");
        string file_name = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(file_name);

        _points = int.Parse(lines[0]);
        lines = lines.Skip(1).ToArray();
        foreach (string line in lines)
        {
            string[] parts = line.Split("#");
            string done = parts[0];
            string type = parts[1];
            string name = parts[2];
            string description = parts[3];
            string pointsForEachCompleation = parts[4];
            if (type == type3)
            {
                done = parts[0];
                type = parts[1];
                name = parts[2];
                description = parts[3];
                pointsForEachCompleation = parts[4];
                SimpleGoal nngoal = new SimpleGoal();
                bool ndone;
                if(done == "[ ]")
                { ndone = false; }
                else
                { ndone = true; }
                nngoal.SetDone(ndone);
                nngoal.SetType(type);
                nngoal.SetName(name);
                nngoal.SetDescription(description);
                nngoal.SetPPC(int.Parse(pointsForEachCompleation));
                _goals.Add(nngoal);
            }
            else if (type == type1)
            {
                done = parts[0];
                type = parts[1];
                name = parts[2];
                description = parts[3];
                pointsForEachCompleation = parts[4];
                string bonuspointsForEachCompleation = parts[5];
                string numOfTimesDid = parts[6];
                string numOfTimesNeeded = parts[7];
                ChecklistGoal nGoal = new ChecklistGoal();
                bool ndone;
                if(done == "[ ]")
                { ndone = false; }
                else
                { ndone = true; }
                nGoal.SetDone(ndone);
                nGoal.SetType(type);
                nGoal.SetType(type);
                nGoal.SetName(name);
                nGoal.SetDescription(description);
                nGoal.SetPPC(int.Parse(pointsForEachCompleation));
                nGoal.SetBonus(int.Parse(bonuspointsForEachCompleation));
                nGoal.SetAD(int.Parse(numOfTimesDid));
                nGoal.SetATD(int.Parse(numOfTimesNeeded));
                _goals.Add(nGoal);
            }
            else
            {
                bool tdone = false;
                EternalGoal ngoal = new EternalGoal();
                ngoal.SetDone(tdone);
                ngoal.SetType(type);
                ngoal.SetName(name);
                ngoal.SetDescription(description);
                ngoal.SetPPC(int.Parse(pointsForEachCompleation));
                _goals.Add(ngoal);
            }
        }
    return _goals;
    }

}